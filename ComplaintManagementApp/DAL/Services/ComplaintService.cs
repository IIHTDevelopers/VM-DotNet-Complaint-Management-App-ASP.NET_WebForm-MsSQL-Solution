using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ComplaintManagementApp.DAL.Interfaces;
using ComplaintManagementApp.Model;

namespace ComplaintManagementApp.DAL.Services
{
    public class ComplaintService : Interfaces.IComplaintService
    {
        private Interfaces.IComplaintRepository _repository;

        public ComplaintService(Interfaces.IComplaintRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            return _repository.GetAll();
        }

        public string Add()
        {
            return _repository.Add();
        }

        public string Update()
        {
            return _repository.Update();
        }

        public string Delete()
        {
            return _repository.Delete();
        }
    }
}