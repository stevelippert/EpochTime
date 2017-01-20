using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpochTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitTimer();
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string preConverted = Clipboard.GetText();
            double unixTime;
            if (Double.TryParse(preConverted, out unixTime))
            {
                DateTime centralTime = UnixTimeStampToHumanTime(unixTime, "Central Standard Time");
                DateTime easternTime = UnixTimeStampToHumanTime(unixTime, "Eastern Standard Time");
                DateTime pacificTime = UnixTimeStampToHumanTime(unixTime, "Pacific Standard Time");

                lblTime1Output.Text = easternTime.ToString("G");
                lblTime2Output.Text = centralTime.ToString("G");
                lblTime3Output.Text = pacificTime.ToString("G");
            }
        }

        public static DateTime UnixTimeStampToHumanTime(double unixTimeStamp, string TimeZone)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            TimeZoneInfo givenZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZone);
            System.DateTime outTime = TimeZoneInfo.ConvertTimeFromUtc(dtDateTime, givenZone);
            return outTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTime2_Click(object sender, EventArgs e)
        {

        }
    }
}
