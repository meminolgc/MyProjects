using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Channels;

#region Menü_Başlangıcı
Console.WriteLine("Api Consume İşlemine Hoşgeldiniz");
Console.WriteLine("\n###Yapmak İstediğiniz İşlemi Seçin###");
Console.WriteLine("\n1-Şehir Listesini Getirin");
Console.WriteLine("\n2-Şehir ve Hava Durumu Listesini Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme");
Console.WriteLine("4-Şehir Silme İşlemi");
Console.WriteLine("5-Şehir Güncelleme İşlemi");
Console.WriteLine("6-ID'ye Göre Şehir Getirme");
#endregion

string number;

Console.Write("\nTercihiniz:");
number = Console.ReadLine();

if (number == "1")
{
	string url = "https://localhost:7149/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url);
		string responseBody = await response.Content.ReadAsStringAsync();
		JArray jArray = JArray.Parse(responseBody);
		foreach (var item in jArray)
		{
			string cityName = item["cityName"].ToString();
			Console.WriteLine($"Şehir: {cityName}");
		}
	}
}

if (number == "2")
{
	string url = "https://localhost:7149/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url);
		string responseBody = await response.Content.ReadAsStringAsync();
		JArray jArray = JArray.Parse(responseBody);
		foreach (var item in jArray)
		{
			string cityName = item["cityName"].ToString();
			string temp = item["temp"].ToString();
			string country = item["country"].ToString();
			Console.WriteLine(cityName + "-" + country + "-->" + temp + "Derece");
		}
	}
}

if (number == "3")
{
	Console.WriteLine("### Yeni Veri Girişi ###");
	Console.WriteLine();

	string cityName, country, detail;
	decimal temp;

	Console.WriteLine("Şehir Adı: ");
	cityName = Console.ReadLine();

	Console.WriteLine("Ülke Adı: ");
	country = Console.ReadLine();

	Console.WriteLine("Hava Durumu Detayı: ");
	detail = Console.ReadLine();

	Console.WriteLine("Sıcaklık: ");
	temp = decimal.Parse(Console.ReadLine());

	string url = "https://localhost:7149/api/Weathers";
	var newWeatherCity = new
	{
		CityName = cityName,
		Country = country,
		Detail = detail,
		Temp = temp
	};

	using (HttpClient client = new HttpClient())
	{
		string json = JsonConvert.SerializeObject(newWeatherCity);
		StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
		HttpResponseMessage response = await client.PostAsync(url, content);
		response.EnsureSuccessStatusCode();
	}
}

if (number == "4")
{
	string url = "https://localhost:7149/api/Weathers?id=";
	Console.Write("Silmek istediğiniz ID değeri: ");
	int id = int.Parse(Console.ReadLine());

	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.DeleteAsync(url + id);
		response.EnsureSuccessStatusCode();
	}
}

if (number == "5")
{
	string url = "https://localhost:7149/api/Weathers?id=";

	Console.WriteLine("### Veri Güncelleme İşlemi ###");
	Console.WriteLine();

	string cityName, country, detail;
	decimal temp;
	int cityId;

	Console.WriteLine("Şehir Adı: ");
	cityName = Console.ReadLine();

	Console.WriteLine("Ülke Adı: ");
	country = Console.ReadLine();

	Console.WriteLine("Hava Durumu Detayı: ");
	detail = Console.ReadLine();

	Console.WriteLine("Sıcaklık: ");
	temp = decimal.Parse(Console.ReadLine());

	Console.Write("Şehir Id: ");
	cityId = int.Parse(Console.ReadLine());

	var updatedWeatherValues = new
	{
		CityId = cityId,
		CityName = cityName,
		Country = country,
		Detail = detail,
		Temp = temp
	};

	using (HttpClient client = new HttpClient())
	{
		string json = JsonConvert.SerializeObject(updatedWeatherValues);
		StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
		HttpResponseMessage response = await client.PutAsync(url, content);
		response.EnsureSuccessStatusCode();
	}
}

if (number == "6")
{
	string url = "https://localhost:7149/api/Weathers/GetByIdWeatherCity?id=";

	Console.WriteLine("Bilgilerini Getirmek İstediğiniz ID Değeri: ");
	int id = int.Parse(Console.ReadLine());

	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url + id);
		response.EnsureSuccessStatusCode();
		string responseBody = await response.Content.ReadAsStringAsync();	
		JObject weatherCityObject = JObject.Parse(responseBody);

		string cityName = weatherCityObject["cityName"].ToString();
		string detail = weatherCityObject["detail"].ToString();
		string country = weatherCityObject["country"].ToString();
		string temp = weatherCityObject["temp"].ToString();

		Console.WriteLine("Girmiş olduğunuz ID değerine ait bilgiler");
        Console.WriteLine();
        Console.Write("Şehir: " + cityName + " Ülke: " + country + " Detay: " + detail + " Sıcaklık: " + temp);
    }
}

Console.Read();
//https://localhost:7149/api/Weathers/GetByIdWeatherCity?id=2