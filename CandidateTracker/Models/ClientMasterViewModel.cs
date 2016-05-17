using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandidateTracker.Models
{
    public class ClientMasterViewModel:BaseViewModel
    {
        public ClientMasterViewModel()
        {
            companyViewModel = new CompanyViewModel();
        }
        public int clientMasterId { get; set; }     
       [DisplayName("Contact Person Name")]
        public string contactPersonName { get; set; }

        [DisplayName("Email Id")]
        public string emailid { get; set; }

        [DisplayName("Phone Number")]
        public string phoneNumber { get; set; }

        [DisplayName("Company Address")]
        public string companyAddress { get; set; }

        public List<CompanyViewModel> ListcompanyViewModel { get; set; }
        public CompanyViewModel companyViewModel { get; set; }

    }
}