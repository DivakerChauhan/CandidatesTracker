using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandidateTracker.Models
{
    public class CompanyViewModel:BaseViewModel
    {
        public int companyId { get; set; }
        [DisplayName("Country Name")]
        public string companyName { get; set; }
    }
}