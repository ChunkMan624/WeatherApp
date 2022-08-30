using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public static List<Stored> dummy = new List<Stored>();

       

       // list.Add(new Stored("Durban", new DateTime(2020,3,5), 28, 23, 20, 10, "3mm"));
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dummy.Add(new Stored("Durban", new DateTime(2020, 3, 5), 28, 23, 20, 10, "3mm"));
            dummy.Add(new Stored("Durban", new DateTime(2020, 3, 6), 26, 24, 15, 8, "1mm"));
            dummy.Add(new Stored("cape town", new DateTime(2020, 3, 5), 28, 23, 20, 10, "3mm"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Stored item in dummy)
            {
                if (cmbCity.Text == item.City && dtpStartDate.Text => item.Stodate)
                {
                    richTextBox1.AppendText(item.City + " " + item.Stodate + " " + item.MaxTemp + " " + item.MinTemp + " " + item.Humidity + " " + item.Precipitation + "\r\n");
                }
            }
        }

     
    }
}
