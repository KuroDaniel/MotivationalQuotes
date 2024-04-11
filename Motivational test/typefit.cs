using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivational_test
{

    public class TypeFit
    {
        public QuoteInfo[] Quotes { get; set; }
    }

    public class QuoteInfo
    {
        public string text { get; set; }
        public string author { get; set; }
    }

    //private static async void APIcall()
    //{
    //    HttpClient client = new HttpClient();
    //    HttpRequestMessage request = new HttpRequestMessage
    //    {
    //        Method = HttpMethod.Get,
    //        RequestUri = new Uri("https://type.fit/api/quotes"),

    //    };

    //    using (HttpResponseMessage response = await client.SendAsync(request))
    //    {
    //        response.EnsureSuccessStatusCode();
    //        string body = await response.Content.ReadAsStringAsync();
    //        TypeFit? result = JsonConvert.DeserializeObject<TypeFit>(body);
    //    }

    
}
