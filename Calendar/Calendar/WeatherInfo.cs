using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunnarSample
{
    class WeatherInfo
    {
        public class coord
        {
            public double lon { get; set; } //City geography location, longitude
            public double lat { get; set; } //City geography location, latitude
        }//end of coord class

        public class weather
        {
            public int id { get; set; } //Weather condition id
            public string main { get; set; } //Group of weather parameters
            public string description { get; set; } //Weather condition within the group
            public string icon { get; set; }
        }//end of class weather

        public class main
        {
            public double temp { get; set; } //Temperature parameter
            public double temp_min { get; set; } //Temperature min parameter
            public double temp_max { get; set; } //Temperature mã parameter
            public double feels_like { get; set; } //Temperature parameter accounts for the human preception of weather
            public double pressure { get; set; } //Atmospheric pressure on the sea level, hPa  
            public double   humidity { get; set; } //Humidity,%
        }//end of class main

        public class wind
        {
            public double speed { get; set; } //Wind speed
        }//end of class wind

        public class sys
        {
            public string country { get; set; } //Coutry code
        }//end of class sys
        public class root
        {
            public string name { get; set; } //City name
            public sys sys { get; set; } 
            public double dt { get; set; } //Time of data forecasts
            public wind wind { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
            public coord coord { get; set; }
            public double visibility { get; set; }
        }//end of class root

    }
}
