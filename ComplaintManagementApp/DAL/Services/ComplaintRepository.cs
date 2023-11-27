using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ComplaintManagementApp.DAL.Interfaces;

namespace ComplaintManagementApp.DAL.Services
{
    public class ComplaintRepository : Interfaces.IComplaintRepository
    {
        private ComplaintDbContext _context;

        public ComplaintRepository(ComplaintDbContext context)
        {
            _context = context;
        }

        public Model.ComplaintModel GetById(int id)
        {
            return _context.ComplaintModels.FirstOrDefault(t => t.ComplaintId == id);
        }

        public string GetAll()
        {
            string qry = "select* from ComplaintModels";
            return qry;
        }

        public string Add()
        {
            string qry = "insert into ComplaintModels(Title, IsResolved, DueDate)" +
                "values('";
            return qry;
        }

        public string Update()
        {
            var query = "update ComplaintModels set Title='";
            return query;
        }

        public string Delete()
        {
            var query = "delete from ComplaintModels where Id='";
            return query;
        }
    }
}