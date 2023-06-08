using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace WindowsFormsApp
{
    public partial class WeatherForm : Form
    {
        private WeathersTable context;
        private GMapOverlay markersOverlay = new GMapOverlay("markers");

        public WeatherForm()
        {
            InitializeComponent();
            context = new WeathersTable();

            //Ustawienie mapy 
            mapControl.DragButton = MouseButtons.Left;
            mapControl.CanDragMap = true;
            mapControl.MapProvider = GMapProviders.GoogleMap;
            mapControl.Position = new PointLatLng(52.2297, 21.0122); // Warszawa
            mapControl.MinZoom = 1;
            mapControl.MaxZoom = 18;
            mapControl.Zoom = 5;
            mapControl.Overlays.Add(markersOverlay);

            LoadDb();
            var weathers = (from wt in context.Weathers select wt).ToList<CityWeather>();
            foreach (CityWeather weather in weathers)
            {
                AddWeatherMarkers(weather);
            }
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string country = CountryInput.Text;
                string city = CityInput.Text;

                //Api call for weather in specified city and country
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://weather-by-api-ninjas.p.rapidapi.com/v1/weather?city=" + city + "&country=" + country),
                    Headers =
                {
                    { "X-RapidAPI-Key", "f1d830866bmsh894ef1aad2cc1a0p1a4176jsn801d806796dc" },
                    { "X-RapidAPI-Host", "weather-by-api-ninjas.p.rapidapi.com" },
                },
                };

                //Api call for city lat and long
                var clientLocation = new HttpClient();
                var requestLocation = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://geocoding-by-api-ninjas.p.rapidapi.com/v1/geocoding?city=" + city),
                    Headers =
                {
                    { "X-RapidAPI-Key", "f1d830866bmsh894ef1aad2cc1a0p1a4176jsn801d806796dc" },
                    { "X-RapidAPI-Host", "geocoding-by-api-ninjas.p.rapidapi.com" },
                },
                };
                //Wait for response
                var response = await client.SendAsync(request);
                var responseLocation = await clientLocation.SendAsync(requestLocation);

                //Are responses successful
                responseLocation.EnsureSuccessStatusCode();
                response.EnsureSuccessStatusCode();

                //Json to CityWeather class
                var stringResult = await response.Content.ReadAsStringAsync();
                var cityWeatherJson = JsonSerializer.Deserialize<CityWeather>(stringResult);
                cityWeatherJson.SetCityName(city);
                cityWeatherJson.SetCountryName(country);

                //Get long and lat and add to CityWeather class
                var stringResultLocation = await responseLocation.Content.ReadAsStringAsync();
                var dataLocation = JArray.Parse(stringResultLocation);
                cityWeatherJson.SetLatitude(double.Parse(dataLocation[0]["latitude"].ToString()));
                cityWeatherJson.SetLongitude(double.Parse(dataLocation[0]["longitude"].ToString()));

                //Add to database and save
                context.Weathers.Add(cityWeatherJson);
                context.SaveChanges();

                //Add to ListBox, Chart and Map
                CitiesListChanged(cityWeatherJson);
                AddNewCityToTempChart(cityWeatherJson, city);
                AddWeatherMarkers(cityWeatherJson);

                //Clear Inputs
                CityInput.Clear();
                CountryInput.Clear();
            }
            catch (HttpRequestException ex)
            {
                // Display the error message in the form
                MessageBox.Show("An error occurred while making the API request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                        // Display the error message in the form
                        MessageBox.Show("An error occurred while parsing the JSON response: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            catch (Exception ex)
            {
                // Display the generic error message in the form
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDb()
        {
            var weathers = (from wt in context.Weathers select wt).ToList<CityWeather>();
            CitiesList.Items.Clear();
            foreach (var series in TempChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var wt in weathers)
            {
                CitiesListChanged(wt);
                AddNewCityToTempChart(wt, wt.GetCityName());
            }
        }

        private void AddWeatherMarkers(CityWeather cityWeather)
        {            
            //Get lat, long and temperature
            double lat = cityWeather.GetLatitude();
            double lon = cityWeather.GetLongitude();
            int temp = cityWeather.GetTemp();

            //Add new Marker
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
            marker.ToolTipText = $"{cityWeather.GetCityName()}: {temp}°C";
            markersOverlay.Markers.Add(marker);         
        }

        private void CitiesListChanged(CityWeather cityWeather)
        {
            CitiesList.Items.Add(cityWeather.ToString());
        }

        private void AddNewCityToTempChart(CityWeather cityWeather, String city)
        {
            List<int> temperaturesList = cityWeather.getCityTemperatures();
            TempChart.Series["Current temp."].Points.AddXY(city, temperaturesList[0]);
            TempChart.Series["Min. temp."].Points.AddXY(city, temperaturesList[1]);
            TempChart.Series["Max. temp."].Points.AddXY(city, temperaturesList[2]);
        }

        private void RefreshChart()
        {
            LoadDb();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            var selectedItem = CitiesList.SelectedItem;
            int selectedIndex = CitiesList.Items.IndexOf(selectedItem);
            int selectedItemDbIndex = int.Parse(CitiesList.GetItemText(selectedItem).Split('.')[0]);

            //Delete selected city marker
            if (markersOverlay != null)
            {
                markersOverlay.Markers.RemoveAt(selectedIndex);
                mapControl.Overlays.Remove(markersOverlay);
                mapControl.Overlays.Add(markersOverlay);
            }

            //Delete selected city from ListBox
            CitiesList.Items.Remove(selectedItem); 
            var s = context.Weathers.First(x => x.ID == selectedItemDbIndex);

            //Delete selected city from database
            context.Weathers.Remove(s);
            context.SaveChanges();

            //Refresh Chart without deleted item
            RefreshChart();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
