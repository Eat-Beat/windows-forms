using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat_Beat.Logic.Entities
{
    public class Restaurant : User
    {
        public double rating { get; set; }
        public string address { get; set; }
        public int addressNum { get; set; }
        public string zipCode { get; set; }
        public Multimedia multimedia { get; set; }
    }
}
