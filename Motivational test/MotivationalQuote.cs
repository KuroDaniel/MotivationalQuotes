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
        public string Quote { get; set; } = "";

        public override string ToString()
        {
            return Quote;
        }
    }


    //more explicit as 
    public class MotivationalQuote1
    {
        [JsonProperty("quote")]
        public string Quote { get; set; } = string.Empty;
    }
}
