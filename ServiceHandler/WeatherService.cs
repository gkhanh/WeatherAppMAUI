using System;
using System.Collections.Generic;
using System.Text;
using WeatherAppMAUI.Models;
using WeatherAppMAUI.WeatherServiceClient;
using System.Threading.Tasks;

namespace WeatherAppMAUI.ServiceHandler
{   //waiting to get data
    public class WeatherService
    {
        AccessWeatherAPI<MainModels> _openWeatherAPI = new AccessWeatherAPI<MainModels>();
        public async Task<MainModels> GetWeatherDetails(string CityName)
        {
            var getWeatherDetails = await _openWeatherAPI.GetAllWeathers(CityName);
            return getWeatherDetails;
        }
    }
}
