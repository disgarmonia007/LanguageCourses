using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageCourses.Models
{
    public class User : IdentityUser
    {
        int idUser { get; set; }
        string name { get; set; }
        string surname { get; set; }
        string email { get; set; }
        string password { get; set; }
        public Group group { get; set; }
        public int? groupId { get; set; }
    }
}
