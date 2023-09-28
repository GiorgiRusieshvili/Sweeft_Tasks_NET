using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_8
{
    public class Country
    {
        public Name name { get; set; }
        public String region { get; set; }
        public String subregion { get; set; }
        public List<Double> latlng { get; set; }

        public double area { get; set; }

        public double population { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }

    }
}

