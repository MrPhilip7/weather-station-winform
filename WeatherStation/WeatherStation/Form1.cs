using Newtonsoft.Json;
using System.Net;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
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
                windspeed_textBox.Text = info.wind.speed.ToString();
                pressure_textBox.Text = info.main.pressure.ToString();
            }
        }

        private object convertTime(string millisec)
        {
            DateTime daySun = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            daySun = daySun.AddSeconds(double.Parse(millisec)).ToLocalTime();
            return daySun;
        }
    }
}