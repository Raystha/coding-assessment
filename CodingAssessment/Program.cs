using CodingAssessment.WeatherData.Helpers;
using System;
using System.Threading.Tasks;

namespace CodingAssessment
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var weatherService = new WeatherService();
            await weatherService.FindSpreadAsync("weather.dat",0,1,2);
            var footballService = new FootballService();
            await footballService.FindSpreadAsync("football.dat",1,6,8);
            Console.ReadKey();
        }
    }
}
