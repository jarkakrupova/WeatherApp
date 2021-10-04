using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherApp {
	[Activity(Label = "CitiesActivity")]
	public class CitiesActivity : Activity {
		TextView textViewOstrava;
		TextView textViewBruntal;
		TextView textViewHelsinki;
		TextView textViewRome;
		TextView textViewOttawa;
		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.cities_layout);
			SetupReferences();
			SubscribeEventHandlers();
		}

		private void SetupReferences() {
			textViewBruntal = FindViewById<TextView>(Resource.Id.textViewBruntal);
			textViewHelsinki = FindViewById<TextView>(Resource.Id.textViewHelsinki);
			textViewOstrava = FindViewById<TextView>(Resource.Id.textViewOstrava);
			textViewOttawa = FindViewById<TextView>(Resource.Id.textViewOttawa);
			textViewRome = FindViewById<TextView>(Resource.Id.textViewRome);
		}

		private void SubscribeEventHandlers() {
			textViewBruntal.Click += TextViewBruntal_Click;
			textViewHelsinki.Click += TextViewHelsinki_Click;
			textViewOstrava.Click += TextViewOstrava_Click;
			textViewOttawa.Click += TextViewOttawa_Click;
			textViewRome.Click += TextViewRome_Click;
		}

		private void TextViewRome_Click(object sender, EventArgs e) {
			GoBackWithCity("Rome");
		}

		private void GoBackWithCity(string city) {
			Intent intent = new Intent();
			intent.PutExtra("City", city);
			SetResult(Result.Ok, intent);
			Finish();
		}

		private void TextViewOttawa_Click(object sender, EventArgs e) {
		GoBackWithCity("Ottawa");
		}

		private void TextViewOstrava_Click(object sender, EventArgs e) {
			GoBackWithCity("Ostrava");
		}

		private void TextViewHelsinki_Click(object sender, EventArgs e) {
			GoBackWithCity("Helsinki");
		}

		private void TextViewBruntal_Click(object sender, EventArgs e) {
			GoBackWithCity("Bruntal");
		}
	}
}