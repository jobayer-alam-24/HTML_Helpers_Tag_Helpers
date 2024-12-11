using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Listbox_Implement.Models;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Listbox_Implement.Controllers;

public class HomeController : Controller
{
    private List<City> GetAvailableCities()
    {
        return new List<City>
            {
                new City(){ CityId = 1, CityName = "London", IsSelected = false },
                new City(){ CityId = 2, CityName = "New York", IsSelected = false },
                new City(){ CityId = 3, CityName = "Sydney", IsSelected = true }, 
                new City(){ CityId = 4, CityName = "Mumbai", IsSelected = false },
                new City(){ CityId = 5, CityName = "Cambridge", IsSelected = false },
                new City(){ CityId = 6, CityName = "Delhi", IsSelected = true },
                new City(){ CityId = 7, CityName = "Hyderabad", IsSelected = false }
            };
        }
    [HttpGet]
    public IActionResult Index()
    {
        
        /* CitiesViewModel citiesViewModel = new CitiesViewModel()
        {
            Cities = GetAvailableCities(),
            SelectedCityIds = GetAvailableCities().Where(x => x.IsSelected).Select(x => x.CityId).ToList()
        };*/
        var Cities = GetAvailableCities().Select(city =>
            new SelectListItem{
                Value = city.CityId.ToString(),
                Text = city.CityName,
                Selected = city.IsSelected
            }
        ).ToList();
        ViewBag.Cities = Cities;
        return View();
    }
    [HttpPost]
    public string SubmittedCities(IEnumerable<int> SelectedCityIds){
        if(SelectedCityIds == null){
            return "No Cities Selected.";
        }
        else
        {
            // var CityNames = GetAvailableCities().Where(x => SelectedCityIds.Contains(x.CityId)).Select(x => x.CityName).ToList();

            var CityNames = GetAvailableCities()
                            .Where(t => SelectedCityIds.Contains(t.CityId)).Select(item => item.CityName).ToList();

            StringBuilder sb = new StringBuilder();
            sb.Append("Your Selected City Names: " + string.Join(", ", CityNames));

            return sb.ToString();
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
