using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandidateTracker.Models;
using CandidateTracker.Filters;


namespace CandidateTracker.Controllers
{
    public class StateController : Controller
    {
        //
        // GET: /State/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [MultiButton(MatchFormKey = "action", MatchFormValue = "Add")] 
        public ActionResult Add(StateViewModel stateViewModel)
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }

    }
}
