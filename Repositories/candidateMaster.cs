//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class candidateMaster
    {
        public candidateMaster()
        {
            this.requirementVendorMappings = new HashSet<requirementVendorMapping>();
        }
    
        public int candidateId { get; set; }
        public string candidateName { get; set; }
        public string jobProfileName { get; set; }
        public Nullable<System.DateTime> experienceStartDate { get; set; }
        public Nullable<System.DateTime> experienceEndDate { get; set; }
        public string mobileNumber { get; set; }
        public Nullable<int> currentExperience { get; set; }
        public string attachedCv { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string modifiedBy { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
    
        public virtual ICollection<requirementVendorMapping> requirementVendorMappings { get; set; }
    }
}
