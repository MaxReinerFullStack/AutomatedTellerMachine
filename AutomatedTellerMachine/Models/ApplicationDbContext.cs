using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public IDbSet<CheckingAccountModel> CheckingAccountModels { get; set; }

        public IDbSet<Transaction> Transactions { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

         public System.Data.Entity.DbSet<AutomatedTellerMachine.Models.TransferViewModel> TransferViewModels { get; set; }
  

    }
    public class FakeApplicationDbContext :  IApplicationDbContext
    {
        public IDbSet<CheckingAccountModel> CheckingAccountModels { get; set; }

        public IDbSet<Transaction> Transactions { get; set; }
        public FakeApplicationDbContext()
        {
        }

        public int SaveChanges()
        {
            return 0;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

}