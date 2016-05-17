using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DocumentObjectModel
{
    public class Base
    {
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
    }
}
