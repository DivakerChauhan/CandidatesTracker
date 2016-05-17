using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandidateTracker.Models
{
    public class CountryViewModel : BaseViewModel
    {
        public int id { get; set; }

        [DisplayName("Country Name")]
        [StringLength(10, ErrorMessage = "must be less than 10")]
        [Required(ErrorMessage = "Country Name Required")]
        public string CountryName { get; set; }
    }
}