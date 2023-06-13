using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WeatherStation.WeatherData;

namespace WeatherStation
{
    internal class WeatherData
    {
        public class Coordinates
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class WeatherInfo
        {
            public double temperature { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }
        public class wind
        {
            public double speed { get; set; }
        }

        public class Sys
        {
            public string sunrise { get; set; }
            public string sunset { get; set;}
        }

        public class WeatherDataNames
        {
            public Coordinates coordinates { get; set; }
            public List<Weather> weather { get; set; }
            public WeatherInfo weatherInfo { get; set; }
            public wind windInfo { get; set; }
            public Sys sys { get; set; }
        }
    }
}
