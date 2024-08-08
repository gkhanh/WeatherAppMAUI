using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherAppMAUI.Models
{

    public class SysID// ID of weather type + location
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
    public class MainModels : SysID//Inherits Sys_ID class to MainModels class
    {
        [JsonProperty("name")]
        public string CityName { get; set; }
        public WeatherTempDetails Main { get; set; }
        public List<WeatherSubDetails> Weather { get; set; }
        public WeatherWindDetails Wind { get; set; }
        public WeatherSysDetails Sys { get; set; }
    }
    public class WeatherSubDetails : IWeatherSubDetails //Inherits IWeatherSubDetails interface to WeatherSubDetails class
    {
        [JsonProperty("main")]
        public string Main { get; set; }
        [JsonProperty("description")]
        public string WeatherDescription { get; set; }
        [JsonProperty("icon")]
        public string WeatherIcon { get; set; }
    }
    public class WeatherSysDetails : IWeatherSysDetails
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }
    public class WeatherTempDetails : IWeatherTempDetails
    {
        [JsonProperty("temp")]
        public string Temperature { get; set; }
        [JsonProperty("humidity")]
        public string Humidity { get; set; }
    }
    public class WeatherWindDetails : IWeatherWindDetails
    {
        [JsonProperty("speed")]
        public string WindSpeed { get; set; }
    }
}
