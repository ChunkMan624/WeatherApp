using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App
{
    class Capture
    {
        private string city;
        private DateTime date;

        public Capture(string city, DateTime date)
        {
            this.City = city;
            this.Date = date;
        }

        public string City { get => city; set => city = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
