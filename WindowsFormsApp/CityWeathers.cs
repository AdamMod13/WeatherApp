using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp
{
    public class WeathersTableWithLocation : System.Data.Entity.DbContext
    {
        public virtual System.Data.Entity.DbSet<CityWeather> Weathers { get; set; }
    }
}
