using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat_Beat.Forms
{
    public class Restaurant : User
    {
        public string address { get; set; }
        public int addressNum { get; set; }
        public string zipCode { get; set; }
    }
}
