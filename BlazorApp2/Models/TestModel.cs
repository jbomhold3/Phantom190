using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class TestModel
    {
        public string NumberAsString { get { return Number.ToString(); } set { Number = Convert.ToInt32(value);  } }
        public int Number { get; set; }

        public string Letter { get; set; }
    }
}
