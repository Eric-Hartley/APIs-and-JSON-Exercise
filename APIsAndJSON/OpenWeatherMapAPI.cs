using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void GetWeatherForecast()
        {
            var client = new HttpClient();
            // Makes request for the internet

            var key = "";
            //var city = "Birmingham";


            //var forecastURL = $"api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}";
            //var response = client.GetStringAsync(forecastURL).Result;

            //JObject formattedResponse = JObject.Parse(response);
            //var temp = formattedResponse["list"][0]["main"]["temp"];
            //Console.WriteLine(temp);



            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter the city name: ");
                var city_name = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    var forecastURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city_name}&appid={key}";
                    var response = client.GetStringAsync(forecastURL).Result;
                    var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                    var temp = JObject.Parse(formattedResponse).GetValue("temp");
                    Console.WriteLine($"The current temperature is {temp} degrees F in {city_name}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Would you like to exit?");
                var userInput = Console.ReadLine();
                
                if(userInput.ToLower().Trim() == "yes")
                {
                    break;
                }

            }

        }
    }
}
