using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivational_test
{
    internal class OlatoQuoteService : IQuoteService
    {
        public async Task<string> GetQuote()
        {
            string quote = "";
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://olato-quotes.p.rapidapi.com/motivation?quotes=random%20quotes"),
                Headers = 
                {
                    { "X-RapidAPI-Key", "b0c049f4b3msh54c2a6eeef6f21bp11432ajsn9d5aabe69714" },
                    { "X-RapidAPI-Host", "olato-quotes.p.rapidapi.com" },
                },
            };
            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                MotivationalQuote? result = JsonConvert.DeserializeObject<MotivationalQuote>(body);
                quote = result?.Quote ?? "";
            }
            return quote;
        }
    }
}
