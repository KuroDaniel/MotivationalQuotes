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

    //this code was taken from the same video, its purpose is to allow parsing of json information and basically assist in calls for when we call one of the APIs. However
    //I am having issues struggling to comprehend how to work with this.

}
