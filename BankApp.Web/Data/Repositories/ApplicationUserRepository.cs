using BankApp.Web.Data.Context;
using BankApp.Web.Data.Entities;
using BankApp.Web.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BankApp.Web.Data.Repositories
{
    public class ApplicationUserRepository :IApplicationUserRepository
    {
        private readonly BankContext _contecxt;

        public ApplicationUserRepository(BankContext context)
        {
            _contecxt = context;
        }

        public List<ApplicationUser> GetAll()
        {
            return _contecxt.ApplicationUsers.ToList();
        }
        public ApplicationUser GetById(int id)
        {
            return _contecxt.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }
    }
}
