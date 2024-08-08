using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherAppMAUI.Models
{
    public interface IWeatherInfo
    {
        string CityName { get; set; }
        WeatherTempDetails Main { get; set; }
        List<WeatherSubDetails> Weather { get; set; }
        WeatherWindDetails Wind { get; set; }
        WeatherSysDetails Sys { get; set; }
    }
    public interface IWeatherSubDetails
    {
        string Main { get; set; }      
        string WeatherDescription { get; set; }       
        string WeatherIcon { get; set; }
    }
    public interface IWeatherSysDetails
    {
        string Country { get; set; }
    }
    public interface IWeatherTempDetails
    {
        string Temperature { get; set; }
        string Humidity { get; set; }
    }
    public interface IWeatherWindDetails
    {
        string WindSpeed { get; set; }
    }
}
