using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Models
{
    public class Group
    {
        public int id { get; set; }
        string UserName { get; set; }
        string GroupName { get; set; }
        public int idTeacher { get; set; }
    }
}
