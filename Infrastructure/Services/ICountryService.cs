using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public interface ICountryService
    {
        List<Country> GetCountries();
        string AddCountry(Country country);
        string UpdateCountry(Country country);
        bool RemoveCountry(int id);  

    }
}
