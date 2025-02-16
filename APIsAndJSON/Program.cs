using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine($"Conversation {i}:");
            //    RonVSKanyeAPI.KanyeQuote();
            //    RonVSKanyeAPI.RonQuote();
            //}

            OpenWeatherMapAPI.GetWeatherForecast();
        }
    }
}
