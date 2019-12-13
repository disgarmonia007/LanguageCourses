using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public class LanguageLVL
    {
        string level { get; set; }
        int id { get; set; }
        public int languageId { get; set; }
       
    }
}
