using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentObjectModel;

namespace Repositories
{
    public class CountryRepository : Base
    {
        /// <summary>
        /// Method for get all Country
        /// </summary>
        /// <returns></returns>
        public List<Country> GetAll()
        {
            List<Country> countryList = new List<Country>();
            Context.countryMasters.ToList().ForEach((country) =>
            {
                Country countryDom = new Country();
                countryDom.id = country.countryId;
                countryDom.CountryName = country.countryName;
                countryList.Add(countryDom);
            });
            return countryList;
        }
        public Country getCountry(int id)
        {
         var countryMaster= Context.countryMasters.Where(x => x.countryId == id).FirstOrDefault();
         Country country = new Country()
         {
             id=countryMaster.countryId,
             CountryName=countryMaster.countryName
         };
            return country;
        }
        public void Delete(int id)
        {
            countryMaster CountryMaster = Context.countryMasters.Where(x => x.countryId == id).FirstOrDefault();
            Context.countryMasters.Remove(CountryMaster);
            Context.SaveChanges();
        }
        /// <summary>
        /// method for save country
        /// </summary>
        /// <param name="country"></param>
        public void Save(Country country)
        {
            countryMaster CountryMaster = new Repositories.countryMaster();
            CountryMaster.countryId = country.id;
            CountryMaster.countryName = country.CountryName;
            Context.countryMasters.Add(CountryMaster);
            Context.SaveChanges();
        }

        /// <summary>
        /// method for Update country
        /// </summary>
        /// <param name="country"></param>
        public void Update(Country country)
        {
            countryMaster CountryMaster = new Repositories.countryMaster();
            CountryMaster = Context.countryMasters.Where(x => x.countryId == country.id).FirstOrDefault();
            if (CountryMaster !=null)
            {
                CountryMaster.countryId = country.id;
                CountryMaster.countryName = country.CountryName;
                Context.SaveChanges();
            }
        }
    }
}
