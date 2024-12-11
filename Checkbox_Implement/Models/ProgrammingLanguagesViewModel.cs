using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkbox_Implement.Models
{
    public class ProgrammingLanguagesViewModel
    {
        public List<LanguageOption> LanguageOptions { get; set; }
    }
    public class LanguageOption{
        public bool IsSelected { get; set; }
        public string LanguageName { get; set; }
    }
}