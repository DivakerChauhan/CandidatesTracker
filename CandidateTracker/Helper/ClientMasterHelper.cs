using BusinessProvider;
using CandidateTracker.Models;
using DocumentObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandidateTracker.Helper
{
    public class ClientMasterHelper
    {
        ClientMasterProvider clientProvider = new ClientMasterProvider();
        public void Add(ClientMasterViewModel clientViewModel)
        {

            var client = new ClientsMaster();
            client.contactPersonName = clientViewModel.contactPersonName;
            client.company.companyId = clientViewModel.companyViewModel.companyId;
            client.companyAddress = clientViewModel.companyAddress;
            client.emailid = clientViewModel.emailid;
            client.phoneNumber = clientViewModel.phoneNumber;
            clientProvider.Save(client);
        }
        public void Update(ClientMasterViewModel clientViewModel)
        {
            var client = new ClientsMaster();
            client.contactPersonName = clientViewModel.contactPersonName;
            client.company.companyId = clientViewModel.companyViewModel.companyId;
            client.companyAddress = clientViewModel.companyAddress;
            client.emailid = clientViewModel.emailid;
            client.phoneNumber = clientViewModel.phoneNumber;
            clientProvider.Save(client);
        }
        /// <summary>
        /// Method for Get all Country and here for example the value table should be like as country while database will not create
        /// </summary>
        /// <returns></returns>
        public ClientMasterDetailsViewModel GetAll()
        {
            ClientMasterDetailsViewModel clientDetailsViewModel = new ClientMasterDetailsViewModel();

            List<ClientsMaster> valueList = clientProvider.GetAll();
            clientDetailsViewModel.ClientMasterViewModelList = new List<ClientMasterViewModel>();
            valueList.ForEach((client) =>
            {
                clientDetailsViewModel.ClientMasterViewModelList.Add(new ClientMasterViewModel()
                {
                    companyViewModel = new CompanyViewModel()
                    {
                        companyId = client.company.companyId,
                        companyName = client.company.companyName
                    },
                    clientMasterId = client.clientMasterId,
                    contactPersonName = client.contactPersonName,
                    companyAddress = client.companyAddress,
                    emailid = client.emailid,
                    phoneNumber = client.phoneNumber
                });

            });
            return clientDetailsViewModel;
        }
        public ClientMasterViewModel getClient(int id)
        {
            ClientsMaster client = clientProvider.getClientMaster(id);
            ClientMasterViewModel clientViewModel = new ClientMasterViewModel()
            {
                companyViewModel = new CompanyViewModel()
                {
                    companyId = client.company.companyId,
                    companyName = client.company.companyName
                },
                clientMasterId = client.clientMasterId,
                contactPersonName = client.contactPersonName,
                companyAddress = client.companyAddress,
                emailid = client.emailid,
                phoneNumber = client.phoneNumber,
            };
            return clientViewModel;
        }
        public void Delete(int id)
        {
            clientProvider.Delete(id);
        }
        public List<CompanyViewModel> getAllCompany()
        {
            List<CompanyViewModel> lst = new List<CompanyViewModel>();
            clientProvider.GetAllCompany().ForEach((company) =>
            {
                CompanyViewModel dom = new CompanyViewModel();
                dom.companyId = company.companyId;
                dom.companyName = company.companyName;
                lst.Add(dom);
            });
            return lst;
        }
    }
}