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
        public Quote[] Quotes { get; set; }
    }

    public class Quote
    {
        public string text { get; set; }
        public string author { get; set; }
    }

}
