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
                WeatherData.WeatherDataNames Info = JsonConvert.DeserializeObject<WeatherData.WeatherDataNames>(json);
                picWeather.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
            }
        }
    }
}