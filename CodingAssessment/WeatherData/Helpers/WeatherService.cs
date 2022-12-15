using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingAssessment.WeatherData.Helpers
{
    internal class WeatherService : SpreadService
    {
        public WeatherService(): base(@"^\s+\d+\s+\d+\s+\d+") { 
        
        }

     
       
    }
}
