using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;
using System.Data.Entity;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp
{
    public partial class WeatherForm : Form
    {
        private WeathersTable context;
        public WeatherForm()
        {
            InitializeComponent();
            context = new WeathersTable();
            LoadDb();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            string country = CountryInput.Text;
            string city = CityInput.Text;
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
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            var cityWeatherJson = JsonSerializer.Deserialize<CityWeather>(stringResult);
            cityWeatherJson.SetCityName(city);
            cityWeatherJson.SetCountryName(country);
            context.Weathers.Add(cityWeatherJson);
            context.SaveChanges();
            CitiesListChanged(cityWeatherJson);
            AddNewCityToTempChart(cityWeatherJson, city);
            CityInput.Clear();
            CountryInput.Clear();
        }

        private void LoadDb()
        {
            var weathers = (from wt in context.Weathers select wt).ToList<CityWeather>();
            Console.WriteLine(weathers.Count);
            foreach (var wt in weathers)
            {
                CitiesListChanged(wt);
                AddNewCityToTempChart(wt, wt.GetCityName());
            }
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
            TempChart.ChartAreas.Clear();
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
            int selectedItemDbIndex = int.Parse(CitiesList.GetItemText(selectedItem).Substring(0,1));
            CitiesList.Items.Remove(selectedItem); 
            var s = context.Weathers.First(x => x.ID == selectedItemDbIndex);
            context.Weathers.Remove(s);
            context.SaveChanges();
            RefreshChart();
        }
    }
}
