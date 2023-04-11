using System;
using System.Diagnostics.Metrics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
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
            Console.WriteLine(body);
        }
    }
}
