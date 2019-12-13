using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public class Teacher
    {
        public int id { get; set; }
        string name { get; set; }
        string surname { get; set; }
        string language { get; set; }
        public Group group { get; set; }
    }
}
