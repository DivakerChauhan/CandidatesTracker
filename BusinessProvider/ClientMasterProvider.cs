using DocumentObjectModel;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProvider
{
   public class ClientMasterProvider
    {
        ClientMasterRepository _clientRepository = new ClientMasterRepository();
        /// <summary>
        ///Method for Get All Country 
        /// </summary>
        /// <returns></returns>
        public List<ClientsMaster> GetAll()
        {
            return _clientRepository.GetAll();
        }
        public ClientsMaster getClientMaster(int id)
        {
            return _clientRepository.getClientMaster(id);
        }
        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
        /// <summary>
        /// Save Country in the database
        /// </summary>
        public void Save(ClientsMaster client)
        {
            _clientRepository.Save(client);
        }
        public void Update(ClientsMaster client)
        {
            _clientRepository.Update(client);
        }

        public List<CompanyMaster> GetAllCompany()
        {
            return _clientRepository.GetAllCompany();
        }
    }
}
