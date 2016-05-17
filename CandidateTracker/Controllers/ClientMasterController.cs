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
    public class ClientMasterController : Controller
    {
        //
        // GET: /ClientMaster/
        ClientMasterViewModel clientMasterViewModel = new ClientMasterViewModel();
        ClientMasterHelper _clientMasterHelper = new ClientMasterHelper();
        public ActionResult Index(int? id)
        {           
            if (id != null)
            {
                clientMasterViewModel = _clientMasterHelper.getClient((int)id);
                clientMasterViewModel.ListcompanyViewModel = BindCompany();
                clientMasterViewModel.FormAction = FormAction.Action.Edit;
            }
            else
            {
                clientMasterViewModel.ListcompanyViewModel = BindCompany();
            }

            return View("Index", clientMasterViewModel);
        }
        private List<CompanyViewModel> BindCompany()
        {
            return _clientMasterHelper.getAllCompany();
        }

        [HttpPost]
        [MultiButton(MatchFormKey = "action", MatchFormValue = "Create")]
        public ActionResult Create(ClientMasterViewModel clientMasterViewModel)
        {
            _clientMasterHelper.Add(clientMasterViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(_clientMasterHelper.GetAll());
        }
    }
}
