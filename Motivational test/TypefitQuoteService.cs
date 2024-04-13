using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivational_test
{
    internal class TypefitQuoteService : IQuoteService
    {
        public async Task<string> GetQuote()
        {
            string quote = "";
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://type.fit/api/quotes"),
            };
            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                TypefitQuote[]? result = JsonConvert.DeserializeObject<TypefitQuote[]>(body);
                if (result != null && result.Length > 0)
                {
                    Random rand =  new Random();
                    int index = rand.Next(result.Length);
                    string author = result[index].author;
                    if (author.EndsWith(", type.fit"))
                    {
                        author = author.Substring(0, author.Length - 10);
                    }
                    quote = $"{result[index].text} - {author}";
                }
            }
            return quote;
        }
    }
}
