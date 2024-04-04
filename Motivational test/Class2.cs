using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivational_test
{

    public class Rootobject
    {
        public string quote { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public Child[] children { get; set; }
    }

    public class Child
    {
        public string name { get; set; }
        public int age { get; set; }
    }

}
