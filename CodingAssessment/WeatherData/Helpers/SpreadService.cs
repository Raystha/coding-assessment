using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingAssessment.WeatherData.Helpers
{
    public abstract class SpreadService
    {
        protected string _regexPattern;
        public SpreadService(string regexPattern) {

           this._regexPattern = regexPattern ?? throw new ArgumentNullException(nameof(regexPattern));
        }

        public async Task FindSpreadAsync(string fileName,int keyIndex, int maxIndex, int minIndex) {

            var dict = new Dictionary<string, int>();

            var data = await File.ReadAllLinesAsync(@$"{fileName}");
            for (int i = 0; i < data.Length; i++)
            {
                var line = data[i];
                Match m = Regex.Match(line, this._regexPattern);
                if (m.Success)
                {

                    var split = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        var key = split[keyIndex];
                        var max = int.Parse(split[maxIndex]);
                        var min = int.Parse(split[minIndex]);
                        dict.Add(key, max - min);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);

                    }
                }

            }

            var smallest = dict.OrderBy(x => x.Value).FirstOrDefault();

            Console.WriteLine($"Minimum Spread Key: {smallest.Key}  Diff: {smallest.Value}");


        }
    }
}
