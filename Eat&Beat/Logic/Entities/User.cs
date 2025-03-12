using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat_Beat.Logic.Entities
{
    internal class User
    {
        private int userId {  get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private List<int> ratings { get; set; }

    }
}
