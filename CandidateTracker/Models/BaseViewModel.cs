using CandidateTracker.MetaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandidateTracker.Models
{
    public class BaseViewModel
    {
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public FormAction.Action FormAction { get; set; }
    }
}