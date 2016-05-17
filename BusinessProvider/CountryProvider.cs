using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentObjectModel;

namespace BusinessProvider
{
   public class CountryProvider
    {
       CountryRepository _countryRepository = new CountryRepository();
       /// <summary>
       ///Method for Get All Country 
       /// </summary>
       /// <returns></returns>
        public List<Country> GetAll() 
        {
             return  _countryRepository.GetAll();
        }
     public Country getCountry(int id) 
        {
            return _countryRepository.getCountry(id);
        }
     public void Delete(int id)
     {
          _countryRepository.Delete(id);
     }
       /// <summary>
       /// Save Country in the database
       /// </summary>
        public void Save(Country country)
        {
            _countryRepository.Save(country);
        }
        public void Update(Country country)
        {
            _countryRepository.Update(country);
        }
    }
}
