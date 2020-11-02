using CountryWebApis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryWebApis.DataBase
{
    public class CountryAndCityContext : DbContext
    {
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
    }
}
