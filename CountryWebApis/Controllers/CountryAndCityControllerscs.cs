using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryWebApis.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountryWebApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryAndCityControllerscs : ControllerBase
    {
        public CountryAndCityControllerscs()
        {
        }

        [HttpPost]
        public void CreateCountries()
        {
        }
        [HttpPost]
        public void CreateCity()
        {
        }
        [HttpGet]
        public List<City> ListCities()
        {
            return new List<City>();
        }
    }
}