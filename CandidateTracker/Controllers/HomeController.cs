using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessProvider;
using CandidateTracker.Helper;
using CandidateTracker.Models;



namespace CandidateTracker.Controllers
{
    public class HomeController : Controller
    {
        CountryHelper _helper = new CountryHelper();
        CountryViewModel countryViewModel = new CountryViewModel();
        CountryDetailsViewModel countryDetailsViewModel = new CountryDetailsViewModel();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
