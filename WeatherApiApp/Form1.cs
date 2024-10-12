using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApiApp.Properties;

namespace WeatherApiApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/Mılano/EN"),
				Headers =
	{
		{ "x-rapidapi-key", "3283d06647mshd151ddd45740f93p1f96dfjsn293e6be9b8e0" },
		{ "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json = JObject.Parse(body);
				var fahrenheit = json["main"]["feels_like"].ToString();
				var windSpeed = json["wind"]["speed"].ToString();
				var humidity = json["main"]["humidity"].ToString();
				lblF.Text = fahrenheit;
				lblHumidity.Text = humidity;
				lblWindSpeed.Text = windSpeed;
				double celsius = (double.Parse(fahrenheit) - 32);
				double celsiusValue = celsius / 1.8;
				lblCelsius.Text = celsiusValue.ToString("0.00");

				var weather = json["weather"][0]["main"].ToString();
				pictureWeather.Text = weather;
			
				switch (weather)
				{
					case "Clouds":
						pictureWeather.ImageLocation = @"C:\Users\memin\Desktop\c_sharp_projeler\MyProjects\WeatherApiApp\Resources\clooudy.png";
						break;
					case "Clear":
						pictureWeather.ImageLocation = @"C:\Users\memin\Desktop\c_sharp_projeler\MyProjects\WeatherApiApp\Resources\sun.png";
						break;
				}
			}
		}

		
	}
}
