namespace WeatherApp
{
    public class WeatherCity
    {
        public int ID { get; set; }
        public int cloud_pct { get; set; }
        public int temp { get; set; }
        public int feels_like { get; set; }
        public int humidity { get; set; }
        public int min_temp { get; set; }
        public int max_temp { get; set;}
        public double wind_speed { get; set; }

        public override string ToString()
        {
            return "Temperatura: " + temp.ToString() + "\n" + "Wilgotność: " + humidity.ToString() + "\n"
                + "Prędkość wiatru [m/s]: " + wind_speed.ToString();
        }
    }
}
