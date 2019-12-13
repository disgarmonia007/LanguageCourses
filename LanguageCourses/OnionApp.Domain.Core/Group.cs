using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public class Group
    {
        public int id { get; set; }
        string UserName { get; set; }
        string GroupName { get; set; }
        public int idTeacher { get; set; }
    }
}
