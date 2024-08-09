using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherAppMAUI.Models
{

    public class SysID// ID of weather type + location
    {
        [JsonProperty("id")]
        public required string ID { get; set; }
    }
    public class MainModels : SysID//Inherits Sys_ID class to MainModels class
    {
        [JsonProperty("name")]
        public required string CityName { get; set; }
        public required WeatherTempDetails Main { get; set; }
        public required List<WeatherSubDetails> Weather { get; set; }
        public required WeatherWindDetails Wind { get; set; }
        public WeatherSysDetails? Sys { get; set; }
    }
    public class WeatherSubDetails : IWeatherSubDetails //Inherits IWeatherSubDetails interface to WeatherSubDetails class
    {
        [JsonProperty("main")]
        public required string Main { get; set; }
        [JsonProperty("description")]
        public required string WeatherDescription { get; set; }
        [JsonProperty("icon")]
        public required string WeatherIcon { get; set; }
    }
    public class WeatherSysDetails : IWeatherSysDetails
    {
        [JsonProperty("country")]
        public required string Country { get; set; }
    }
    public class WeatherTempDetails : IWeatherTempDetails
    {
        [JsonProperty("temp")]
        public required string Temperature { get; set; }
        [JsonProperty("humidity")]
        public required string Humidity { get; set; }
    }
    public class WeatherWindDetails : IWeatherWindDetails
    {
        [JsonProperty("speed")]
        public required string WindSpeed { get; set; }
    }
}
