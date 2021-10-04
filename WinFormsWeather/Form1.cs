using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWeather {
	public partial class Form1 : Form, IWeatherView{
		WeatherService weatherService;
		public Form1() {
			InitializeComponent();
			weatherService = new WeatherService(this);
		}

		public void SetWeatherData(WeatherModel weatherModel) {

			labelCity.Text = weatherModel.location.name;
			labelHumidity.Text = $"Humidity: {weatherModel.current.humidity}";
			labelLocalTime.Text = $"Local time: {weatherModel.location.localtime}";
			labelTemperature.Text = $"Temperature: {weatherModel.current.temperature}";
			labelWeather.Text = weatherModel.current.weather_descriptions[0];
			labelWind.Text = $"{weatherModel.current.wind_speed} km/h {weatherModel.current.wind_dir}";
		}

		private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e) {
			string city = comboBoxCities.SelectedItem.ToString();
			weatherService.GetWeatherForCityAsync(city);
		}
	}
}
