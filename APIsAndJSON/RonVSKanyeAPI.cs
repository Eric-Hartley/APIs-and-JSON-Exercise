using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();
            // Makes request for the internet

            var kanyeURL = "https://api.kanye.rest";
            // URL for the API to get the responses

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            // Gets the response and stores in variable

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            // Parses the response from the js object and looks for the value referenced by the quote

            Console.WriteLine("");
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine("");
        }
        public static void RonQuote()
        {
            var client = new HttpClient();
            // Makes request to access internet

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            // Puts URL for Ron's responses into variable

            var ronResponse = client.GetStringAsync(ronURL).Result;
            // Gets the response from the URL and stores in variable

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            // Parses the response from the js array and cleans it up

            Console.WriteLine($"Ron: {ronQuote}");
            Console.WriteLine("----------------------");
        }
    }
}
