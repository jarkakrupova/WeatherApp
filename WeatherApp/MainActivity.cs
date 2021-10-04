using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Shared;
using Android.Graphics;

namespace WeatherApp {
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
	public class MainActivity : AppCompatActivity, IWeatherView, ISunriseSunsetView {
		ImageView imageViewPicture;
		TextView textViewCity;
		TextView textViewWeather;
		TextView textViewTemperature;
		TextView textViewWind;
		TextView textViewHumidity;
		TextView textViewLocalTime;
		Button buttonChange;
		WeatherService weatherService;
		SunriseSunsetService sunriseSunsetService;
		TextView textViewSunrise;
		TextView textViewSunset;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);
			Xamarin.Essentials.Platform.Init(this, savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);
			SetupReferences();
			SubscribeEventHandlers();
		}

		private void SubscribeEventHandlers() {
			buttonChange.Click += ButtonChange_Click;
		}

		private void ButtonChange_Click(object sender, EventArgs e) {
			Intent intent = new Intent(this, typeof(CitiesActivity));
			StartActivityForResult(intent, 1);
		}

		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data) {
			if (requestCode == 1 && resultCode == Result.Ok) {
				string city = data.GetStringExtra("City");
				textViewCity.Text = city;
				weatherService.GetWeatherForCityAsync(city);
			}
		}

		private void SetupReferences() {
			imageViewPicture = FindViewById<ImageView>(Resource.Id.imageViewPicture);
			textViewCity = FindViewById<TextView>(Resource.Id.textViewCity);
			textViewWeather = FindViewById<TextView>(Resource.Id.textViewWeather);
			textViewTemperature = FindViewById<TextView>(Resource.Id.textViewTemperature);
			textViewWind = FindViewById<TextView>(Resource.Id.textViewWind);
			textViewHumidity = FindViewById<TextView>(Resource.Id.textViewHumidity);
			textViewLocalTime = FindViewById<TextView>(Resource.Id.textViewLocalTime);
			buttonChange = FindViewById<Button>(Resource.Id.buttonChange);
			weatherService = new WeatherService(this);
			sunriseSunsetService = new SunriseSunsetService(this);
			textViewSunrise = FindViewById<TextView>(Resource.Id.textViewSunrise);
			textViewSunset = FindViewById<TextView>(Resource.Id.textViewSunset);
		}

		private Bitmap GetImageBitmapFromUrl(string url) {
			Bitmap imageBitmap = null;
			using (var webClient = new System.Net.WebClient()) {
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0) {
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}
			return imageBitmap;
		}

		public void SetWeatherData(WeatherModel weatherModel) {
			textViewCity.Text = weatherModel.location.name;
			textViewWeather.Text = weatherModel.current.weather_descriptions[0];
			textViewHumidity.Text = weatherModel.current.humidity.ToString();
			textViewLocalTime.Text = weatherModel.location.localtime;
			textViewTemperature.Text = weatherModel.current.temperature.ToString();
			textViewWind.Text = $"{weatherModel.current.wind_speed} km//h {weatherModel.current.wind_dir}";
			imageViewPicture.SetImageBitmap(GetImageBitmapFromUrl(weatherModel.current.weather_icons[0]));
			sunriseSunsetService.GetSunriseSunsetInfoAsync(weatherModel.location.lat, weatherModel.location.lon);
		}

		public void SetSunriseSunsetView(SunriseSunsetModel sunriseSunsetModel) {
			textViewSunrise.Text = sunriseSunsetModel.results.sunrise;
			textViewSunset.Text = sunriseSunsetModel.results.sunset;
		}
	}
}