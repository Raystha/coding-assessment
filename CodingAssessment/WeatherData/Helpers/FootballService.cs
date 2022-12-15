using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingAssessment.WeatherData.Helpers
{
    internal class FootballService : SpreadService
    {
        public FootballService(): base("^\\s+\\d+\\.\\s\\w+\\s+\\d+\\s+\\d+\\s+\\d+\\s+\\d+\\s+\\d+\\s+-\\s+\\d+") { 
        
        }

    }
}
