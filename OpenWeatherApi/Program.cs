using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OpenWeatherApi
{
    class Program
    {
        static void Main(string[] args)
        {

            //open weather api
			HttpClient weatherClient = new HttpClient();
			Task<string> task = weatherClient.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?zip=35228&APPID=b0ee1bc5a19cacdf606c2376ffde065c");
			string jsonText = task.Result;
			JObject jsonResult = JObject.Parse(jsonText);
			string tempCheck = jsonResult["main"]["temp"].ToString();
			Console.WriteLine(tempCheck);


		}
    }
}
