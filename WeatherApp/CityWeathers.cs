using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WeatherApp
{
    public class CityWeathers : System.Data.Entity.DbContext
    {
        public virtual System.Data.Entity.DbSet<CityWeather> Weather { get; set; }
    }
}
