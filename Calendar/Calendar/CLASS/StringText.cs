using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace LunnarSample
{
    class StringText
    {
        private static string FileText(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"FileText\", fileName);
            return filePath;
        }
        public class CityIDClass
        {
            public string CityName { get; set; }
            public string CityID { get; set; }
        }
        public List<CityIDClass> CityIDList = new List<CityIDClass>();
        public class MainWeatherClass
        {
            public string eMainWeather { get; set; }
            public string vMainWeather { get; set; }
        }
        public List<MainWeatherClass> MainWeatherList = new List<MainWeatherClass>();
        public class DescriptionWeatherClass
        {
            public string eDescriptionWeather { get; set; }
            public string vDescriptionWeather { get; set; }
        }
        public List<DescriptionWeatherClass> DescriptionWeatherList = new List<DescriptionWeatherClass>();
        public void GetList()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileText("IDCity.txt"), Encoding.UTF8);
            while ((line = streamReader.ReadLine()) != null)
            {
                CityIDClass cityid = new CityIDClass();
                string[] words = line.Split('|');
                cityid.CityName = words[0];
                cityid.CityID = words[1];
                CityIDList.Add(cityid);
            }
            streamReader = new StreamReader(FileText("MainWeather.txt"), Encoding.UTF8);
            while ((line = streamReader.ReadLine()) != null)
            {
                MainWeatherClass mainWeather = new MainWeatherClass();
                string[] words = line.Split('|');
                mainWeather.eMainWeather = words[0];
                mainWeather.vMainWeather = words[1];
                MainWeatherList.Add(mainWeather);
            }
            streamReader = new StreamReader(FileText("DescriptionWeather.txt"), Encoding.UTF8);
            while ((line = streamReader.ReadLine()) != null)
            {
                DescriptionWeatherClass descriptionWeather = new DescriptionWeatherClass();
                string[] words = line.Split('|');
                descriptionWeather.eDescriptionWeather = words[0];
                descriptionWeather.vDescriptionWeather = words[1];
                DescriptionWeatherList.Add(descriptionWeather);
            }

        }
        public string IsEqualCityName(string city)
        {
            foreach(CityIDClass cityID in CityIDList)
            {
                if (String.Compare(city,cityID.CityName,true) == 0)
                    return cityID.CityID;
            }
            return "";
        }
        public string IsEqualMainWeather(string mWeather)
        {
            foreach (MainWeatherClass mainWeather in MainWeatherList)
            {
                if (String.Compare(mWeather,mainWeather.eMainWeather,true) == 0)
                    return mainWeather.vMainWeather;
            }
            return "";
        }
        public string IsEqualDescriptionWeather(string dWeather)
        {
            foreach (DescriptionWeatherClass descriptionWeather in DescriptionWeatherList)
            {
                if (String.Compare(dWeather,descriptionWeather.eDescriptionWeather,true)== 0)
                    return descriptionWeather.vDescriptionWeather;
            }
            return "";
        }
        public class QuoteClass
        {
            public string Author { get; set; }
            public string Quote { get; set; }
            public override string ToString()
            {
                return string.Format("{0}."+ "({1})",Quote, Author);
            }
        }
        public static List<QuoteClass> QuoteList = new List<QuoteClass>();
        public static void GetQuote()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileText("ChamNgon.txt"), Encoding.UTF8);
            while ((line = streamReader.ReadLine()) != null)
            {
                QuoteClass quote = new QuoteClass();
                string[] words = line.Split('|');
                quote.Author = words[0];
                quote.Quote = words[1];
                QuoteList.Add(quote);
            }
        }
        public QuoteClass MakeRandomQuote()
        {
            int length = QuoteList.Count;
            Random rand = new Random();
            int temp = rand.Next(0, length - 1);
            return QuoteList[temp];
        }

        private static Image loadImage(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Images\", fileName);
            Image image = new Bitmap(filePath);
            return image;
        }
        public static Image HoangDao;
        public static Image HacDao;
        public static void DrawImage()
        {
            HoangDao = loadImage("HoangDao.png");
            HacDao = loadImage("HacDao.png");
        }

        public static string hdsd = "";

        public static string StringHDSD()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileText("HDSD.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }

        public static void GetHDSD()
        {
            hdsd = StringHDSD();
        }
    }
}
