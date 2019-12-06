using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Models
{
    public class Admin
    {
       public int idAdmin { get; set; }
        string name { get; set; }
        string surname { get; set; }
        string email { get; set; }
        string password { get; set; }
    }
}
