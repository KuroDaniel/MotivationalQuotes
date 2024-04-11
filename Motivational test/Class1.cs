using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Motivational_test
{
    public class MotivationalQuote
    {
        public string Quote { get; set; }

        public override string ToString()
        {
            return Quote;
        }
    }

    public class quoteprocess { 
    public static async Task<MotivationalQuote1> Loadquote(string quoteOptions)
    {
            string url = "";

            if (quoteOptions.Contains("1"))
            {
                url = $"https://type.fit/api/quotes";
            }
            else if (quoteOptions.Contains("2"))
            {
                url = $"https://olato-quotes.p.rapidapi.com/motivation?quotes=random%20quotes";
            }
        using (HttpResponseMessage response = await APIassist.APIclient.GetAsync(url)) 
            { 
            if (response.IsSuccessStatusCode)
                {
                    MotivationalQuote1 quote = await response.Content.ReadAsAsync<MotivationalQuote1>();

                    return quote;
                }

            else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
    }

    }


    //more explicit as 
    public class MotivationalQuote1
    {
        [JsonProperty("quote")]
        public string Quote { get; set; }
    }


}
