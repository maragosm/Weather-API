using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Weather_API
{
    public class WeatherApp
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
            return temp;
        }
    }
}
