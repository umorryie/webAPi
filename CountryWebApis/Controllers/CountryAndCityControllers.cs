using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryWebApis.DataBase;
using CountryWebApis.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountryWebApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryAndCityController : ControllerBase
    {
        public CountryAndCityController()
        {
        }

        [HttpPost]
        public void CreateCountries()
        {
        }
        [HttpPost]
        public void CreateCity([FromBody] List<string> countries)
        {
            using (var db = new CountryAndCityContext())
            {
                var index = db.Country.Count();
                countries.ForEach(country =>
                {
                    try
                    {
                        db.Add(new Country { Name = country, Id = index });
                        index++;
                    }
                    catch
                    {
                        _logger(@'Something went wrong when logging {country}.');
                    }
                });

            }
        }
        [HttpGet]
        public List<City> ListCities()
        {
            return new List<City>();
        }

        [HttpGet, Route("/createNewDataBase")]
        public void CreateNewFreshDataBase()
        {
        }
    }
}