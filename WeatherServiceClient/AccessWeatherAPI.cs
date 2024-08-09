using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using WeatherAppMAUI.Models;

namespace WeatherAppMAUI.WeatherServiceClient
{
    public class AccessWeatherAPI<T>
    {
        private const string OpenWeatherAPI = "https://api.openweathermap.org/data/2.5/weather?q=";
        // private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";
        private const string API_Key = "136bd4ea8e928fccaa398d678028f205";
        HttpClient _httpClient = new HttpClient();

        //waiting to receive data from API link
        public async Task<T> GetAllWeathers(string city)
        {
            var json = await _httpClient.GetStringAsync(OpenWeatherAPI + city + "&APPID=" + API_Key);
            var getWeatherModels = JsonConvert.DeserializeObject<T>(json);
            return getWeatherModels;
        }
    }
}
