using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class CityWeather
    {
        public int cloud_pct { get; set; }
        public int temperature { get; set; }
        public int temp_feels_like { get; set; }
        public int humidity { get; set; }
        public int min_temp { get; set; }
        public int max_temp { get; set;}
        public double wind_speed { get; set; }

        [JsonConverter] public CityWeather(string response)

    }
}
