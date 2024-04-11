using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Motivational_test
{

    public class APIassist
    {
        public static HttpClient APIclient { get; set; }

        public static void Initializer()
        {
            APIclient = new HttpClient();
            APIclient.DefaultRequestHeaders.Accept.Clear();
            APIclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }

}
