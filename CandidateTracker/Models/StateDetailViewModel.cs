using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandidateTracker.Models
{
    public class StateDetailViewModel:StateViewModel
    {
        public List<StateViewModel> lstStateViewModel { get; set; }
    }
}