using Newtonsoft.Json;
using System.Net;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        static double modPressure = 0;
        static double modWindSpeed = 0;
        static double modTemp = 0;
        Random random = new Random();
        public double temp = 0;

        public Form1()
        {
            InitializeComponent();

        }

        string APIkey = "8c79a7cdc3ecc1a8237d758664a2cd27";

        private void data_button_Click(object sender, EventArgs e)
        {
            checkWeather();
        }

        private void checkWeather()
        {
            using (WebClient web = new WebClient())
            {


                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city_textBox.Text, APIkey);
                var json = web.DownloadString(url);
                WeatherData.WeatherDataNames info = JsonConvert.DeserializeObject<WeatherData.WeatherDataNames>(json);
                picWeather.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                conditions_textBox.Text = info.weather[0].main;
                detail_textBox.Text = info.weather[0].description;
                sunset_textBox.Text = convertTime(info.sys.sunset).ToString();
                sunrise_textBox.Text = convertTime(info.sys.sunrise).ToString();
                windspeed_textBox.Text = (info.wind.speed + modWindSpeed).ToString();
                pressure_textBox.Text = (info.main.pressure + modPressure).ToString();

                temp = random.NextDouble() * 10;
                temp_textBox.Text = (temp + modTemp).ToString();
            }
        }

        private object convertTime(string millisec)
        {
            DateTime daySun = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            daySun = daySun.AddSeconds(double.Parse(millisec)).ToLocalTime();
            return daySun;
        }

        private void btnPressurePlus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(pressure_textBox.Text);
            value += 1;
            pressure_textBox.Text = value.ToString();
            modPressure += 1;
        }

        private void btnWindPlus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(pressure_textBox.Text);
            value += 1;
            pressure_textBox.Text = value.ToString();
            modWindSpeed += 1;
        }

        private void btnPressureMin_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(pressure_textBox.Text);
            value -= 1;
            pressure_textBox.Text = value.ToString();
            modPressure -= 1;
        }

        private void btnWindMin_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(pressure_textBox.Text);
            value -= 1;
            pressure_textBox.Text = value.ToString();
            modWindSpeed -= 1;
        }

        private void temp_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTempPlus_Click(object sender, EventArgs e)
        {
            modTemp += 1;
            temp_textBox.Text = (temp + modTemp).ToString();
        }

        private void btnTempMin_Click(object sender, EventArgs e)
        {
            modTemp -= 1;
            temp_textBox.Text = (temp + modTemp).ToString();
        }
    }
}