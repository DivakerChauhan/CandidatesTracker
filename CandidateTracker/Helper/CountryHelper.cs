using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocumentObjectModel;
using CandidateTracker.Models;
using BusinessProvider;

namespace CandidateTracker.Helper
{
    public class CountryHelper
    {
        CountryProvider countryProvider = new CountryProvider();
        public void Add(CountryViewModel countryViewModel)
        {
            var country = new Country();
            country.id = countryViewModel.id;
            country.CountryName = countryViewModel.CountryName;
            countryProvider.Save(country);
        }
        public void Update(CountryViewModel countryViewModel)
        {
            var country = new Country();
            country.id = countryViewModel.id;
            country.CountryName = countryViewModel.CountryName;
            countryProvider.Update(country);
        }
        /// <summary>
        /// Method for Get all Country and here for example the value table should be like as country while database will not create
        /// </summary>
        /// <returns></returns>
        public CountryDetailsViewModel GetAll()
        {
            CountryDetailsViewModel countryDetailsViewModel = new CountryDetailsViewModel();

            List<Country> valueList = countryProvider.GetAll();
            countryDetailsViewModel.listCountryViewModel = new List<CountryViewModel>();
            valueList.ForEach((country) =>
            {
                countryDetailsViewModel.listCountryViewModel.Add(new CountryViewModel()
                {
                    id = country.id,
                    CountryName = country.CountryName
                });
            });
            return countryDetailsViewModel;
        }
        public CountryViewModel getCountry(int id)
        {
            Country country = countryProvider.getCountry(id);
            CountryViewModel countryViewModel = new CountryViewModel()
          {
              id = country.id,
              CountryName = country.CountryName
          };
            return countryViewModel; 
        }
        public void Delete(int id)
        {
            countryProvider.Delete(id);
        }

    }
}