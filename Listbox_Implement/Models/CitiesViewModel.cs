using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Listbox_Implement.Models
{
    public class CitiesViewModel
    {
        public IEnumerable<int> SelectedCityIds { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}