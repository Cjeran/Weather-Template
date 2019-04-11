using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            location.Text = Form1.days[0].location;
            currentTemp.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.0") + "°C";
            min.Text = Convert.ToDouble(Form1.days[0].min).ToString("0.0") + "°C";
            max.Text = Convert.ToDouble(Form1.days[0].max).ToString("0.0") + "°C";
            date.Text = DateTime.Now.ToString("dd-MM-yy");
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            precipitation.Text = Form1.days[0].precipitation;
            humidity.Text = Form1.days[0].humidity;
            windspeed.Text = Form1.days[0].windSpeed;
            windDirection.Text = Form1.days[0].windDirection;

            double code = Convert.ToDouble(Form1.days[0].condition);

            if (code >= 200 && code <= 232)
            {
                currentPic.Image = Properties.Resources.thunderstorm;
            }
            else if (code >= 300 && code <= 321)
            {
                currentPic.Image = Properties.Resources.shower;
            }
            else if (code >= 500 && code <= 531)
            {
                currentPic.Image = Properties.Resources.rain;
            }
            else if (code >= 600 && code <= 622)
            {
                currentPic.Image = Properties.Resources.snow;
            }
            else if (code >= 700 && code <= 781)
            {

            }
            else if (code == 800)
            {
                currentPic.Image = Properties.Resources.clear1;
            }
            else if (code >= 801 && code <= 804)
            {
                currentPic.Image = Properties.Resources.cloudy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
