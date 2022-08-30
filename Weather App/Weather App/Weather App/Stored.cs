using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App
{
    public class Stored
    {
        private string city;
        private DateTime stodate;
        private int maxTemp;
        private int minTemp;
        private int windSpeed;
        private int humidity;
        private string precipitation;

        public Stored(string city, DateTime stodate, int maxTemp, int minTemp, int windSpeed, int humidity, string precipitation)
        {
            this.city = city;
            this.stodate = stodate;
            this.maxTemp = maxTemp;
            this.minTemp = minTemp;
            this.windSpeed = windSpeed;
            this.humidity = humidity;
            this.precipitation = precipitation;
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public DateTime Stodate
        {
            get { return stodate; }
            set { stodate = value; }
        }
        public int MaxTemp
        {
            get { return maxTemp; }
            set { maxTemp = value; }
        }
        public int MinTemp
        {
            get { return minTemp; }
            set { minTemp = value; }
        }
        public int WindSpeed
        {
            get { return windSpeed; }
            set { windSpeed = value; }
        }
        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        public string Precipitation
        {
            get { return precipitation; }
            set { precipitation = value; }
        }
    }
    }