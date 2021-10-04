using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace WeatherApp {
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
	public class MainActivity : AppCompatActivity {
		ImageView imageViewPicture;
		TextView textViewCity;
		TextView textViewWeather;
		TextView textViewTemperature;
		TextView textViewWind;
		TextView textViewHumidity;
		TextView textViewLocalTime;
		Button buttonChange;

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
		}
	}
}