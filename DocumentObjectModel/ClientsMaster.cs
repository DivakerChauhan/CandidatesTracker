using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentObjectModel
{
    public class ClientsMaster
    {
        public ClientsMaster()
        {
            company = new CompanyMaster();
        }
        public int clientMasterId { get; set; }
        public string contactPersonName { get; set; }
        public string emailid { get; set; }
        public string phoneNumber { get; set; }
        public string companyAddress { get; set; }
        public CompanyMaster company { get; set; }
    }
}
