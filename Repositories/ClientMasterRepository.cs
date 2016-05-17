using DocumentObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
   public class ClientMasterRepository:Base
    {
        /// <summary>
        /// Method for get all Client
        /// </summary>
        /// <returns></returns>
        public List<ClientsMaster> GetAll()
        {
            List<ClientsMaster> clientMasterList = new List<ClientsMaster>();
            Context.clientMasters.ToList().ForEach((client) =>
            {
                ClientsMaster clientMaster = new ClientsMaster();
                clientMaster.company.companyId = client.companyMaster.id;
                clientMaster.company.companyName = client.companyMaster.name;
                clientMaster.clientMasterId = client.clientMasterId;
                clientMaster.contactPersonName = client.contactPersonName;
                clientMaster.emailid = client.emailId;
                clientMaster.companyAddress = client.companyAddress;
                clientMaster.phoneNumber = client.phoneNo;
                clientMasterList.Add(clientMaster);
            });
            return clientMasterList;
        }
        public ClientsMaster getClientMaster(int id)
        {
            var clientMaster = Context.clientMasters.Where(x => x.clientMasterId == id).FirstOrDefault();
            ClientsMaster client = new ClientsMaster()
            {
                clientMasterId = clientMaster.clientMasterId,
                contactPersonName = clientMaster.contactPersonName,
                emailid = clientMaster.emailId,
                phoneNumber = clientMaster.phoneNo,
                companyAddress = clientMaster.companyAddress
            };
            CompanyMaster companyMasters = new CompanyMaster()
            {
                companyId = clientMaster.companyId,
                companyName = clientMaster.companyMaster.name
            };
            client.company = companyMasters;
            return client;
        }
        public void Delete(int id)
        {
            clientMaster clientMasters = Context.clientMasters.Where(x => x.clientMasterId == id).FirstOrDefault();
            Context.clientMasters.Remove(clientMasters);
            Context.SaveChanges();
        }
        /// <summary>
        /// method for save client
        /// </summary>
        /// <param name="country"></param>
        public void Save(ClientsMaster client)
        {
            clientMaster clientMasters = new Repositories.clientMaster();
            clientMasters.companyId = client.company.companyId;
            clientMasters.contactPersonName = client.contactPersonName;
            clientMasters.emailId = client.emailid;
            clientMasters.phoneNo = client.phoneNumber;
            clientMasters.companyAddress = client.companyAddress;
            Context.clientMasters.Add(clientMasters);
            Context.SaveChanges();
        }

        /// <summary>
        /// method for Update client
        /// </summary>
        /// <param name="country"></param>
        public void Update(ClientsMaster clientInfo)
        {
            clientMaster client = new Repositories.clientMaster();
            client = Context.clientMasters.Where(x => x.clientMasterId == clientInfo.clientMasterId).FirstOrDefault();
            if (client != null)
            {
                client.companyId = clientInfo.company.companyId;
                client.contactPersonName = clientInfo.contactPersonName;
                client.emailId = clientInfo.emailid;
                client.phoneNo = clientInfo.phoneNumber;
                client.companyAddress = clientInfo.companyAddress;
                Context.SaveChanges();
            }
        }
        /// <summary>
        /// Method for get all Company
        /// </summary>
        /// <returns></returns>
        public List<CompanyMaster> GetAllCompany()
        {
            List<CompanyMaster> companyMasterList = new List<CompanyMaster>();
            Context.companyMasters.ToList().ForEach((company) =>
            {
                CompanyMaster companyMaster = new CompanyMaster();
                companyMaster.companyId = company.id;
                companyMaster.companyName = company.name;
                companyMasterList.Add(companyMaster);
            });
            return companyMasterList;
        }
    }
}
