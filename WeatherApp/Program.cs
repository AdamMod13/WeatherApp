using System.Text.Json;

namespace WeatherApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var context = new CityWeathers();
            Console.WriteLine("Pass country:");
            string country = Console.ReadLine();
            Console.WriteLine("Pass city");
            string city = Console.ReadLine();
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
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var cityWeatherJson = JsonSerializer.Deserialize<CityWeather>(body);
            context.Weathers.Add(cityWeatherJson);
            context.SaveChanges();

            var weathers = (from s in context.Weathers select s).ToList<CityWeather>();
            foreach (var wt in weathers)
            {
                Console.WriteLine("ID: {0}, Temp: {1}, Wind speed: {2:0.00}", wt.ID, wt.temp, wt.wind_speed);
            }
        }
    }
}
