﻿using System.Collections.Generic;

namespace WindowsFormsApp
{
    public class CityWeather
    {
        public int ID { get; set; }
        public string cityName { get; set; }
        public string countryName { get; set; }
        public int cloud_pct { get; set; }
        public int temp { get; set; }
        public int feels_like { get; set; }
        public int humidity { get; set; }
        public int min_temp { get; set; }
        public int max_temp { get; set;}
        public double wind_speed { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }   

        public override string ToString()
        {
            return ID.ToString() + ". " + cityName + " - " + countryName;
        }

        public List<int> getCityTemperatures()
        {
            List<int> temperaturesList = new List<int>();
            temperaturesList.Add(temp);
            temperaturesList.Add(min_temp);
            temperaturesList.Add(max_temp);

            return temperaturesList;
        }

        public int GetTemp()
        {
            return temp;
        }

        public string GetCityName()
        {
            return cityName;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public void SetCityName(string city)
        {
            cityName = city;
        }

        public void SetCountryName(string country)
        {
            countryName = country;
        }

        public void SetLatitude(double lat)
        {
            latitude = lat;
        }

        public void SetLongitude(double longit)
        {
            longitude = longit;
        }

        public double GetLatitude()
        {
            return latitude;
        }

        public double GetLongitude()
        {
            return longitude;
        }

        public int GetID()
        {
            return ID;
        }
    }
}
