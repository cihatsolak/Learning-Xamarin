using Course.ListYapilari.Model;
using System.Collections.Generic;

namespace Course.ListYapilari.ViewModel
{
    public class CityViewModel
    {
        public List<City> Cities { get; set; }

        public CityViewModel()
        {
            Cities = GetCities();
        }

        List<City> GetCities()
        {
            return new List<City>
            {
               new City{Plaka=34,Sehir="İstanbul"},
               new City{Plaka=06,Sehir="Ankara"},
               new City{Plaka=35,Sehir="İzmir"},
               new City{Plaka=07,Sehir="Antalya"}
            };
        }
    }
}
