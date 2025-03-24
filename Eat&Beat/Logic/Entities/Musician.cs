using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat_Beat.Logic.Entities
{
    public class Musician : User
    {
        public double rating { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string description { get; set; }
        public List<Multimedia> multimedia { get; set; }
        public List<string> genre { get; set; }
        public List<string> classification { get; set; }
    }
}
