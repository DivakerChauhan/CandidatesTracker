using CandidateTracker.Filters;
using CandidateTracker.Helper;
using CandidateTracker.MetaData;
using CandidateTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandidateTracker.Controllers
{
    public class CountryController : Controller
    {
        //
        // GET: /Country/
        CountryHelper _countryHelper = new CountryHelper();
        [HttpGet]
        public ActionResult Index(int? id = null)
        {
            var countryViewModel = new CountryViewModel();
            if (id!=null)
            {
               
                countryViewModel = _countryHelper.getCountry((int)id);
                countryViewModel.FormAction = FormAction.Action.Edit;
            }
            else
            {

            }
           
            return View("Index", countryViewModel);
        }
        [HttpPost]
        [MultiButton(MatchFormKey = "action", MatchFormValue = "Create")] 
        public ActionResult Create(CountryViewModel countryViewModel)
        {
            _countryHelper.Add(countryViewModel);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [MultiButton(MatchFormKey = "action", MatchFormValue = "Update")]
        public ActionResult Update(CountryViewModel countryViewModel)
        {
            _countryHelper.Update(countryViewModel);
            return RedirectToAction("Index");
        }
        /// <summary>
        /// metjod to get all country
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View(_countryHelper.GetAll());
        }
        public ActionResult Delete(int id)
        {
            _countryHelper.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [MultiButton(MatchFormKey = "action", MatchFormValue = "Cancel")]
        public ActionResult Cancel()
        {
           return RedirectToAction("Index");
        }
    }
}
