using System.Data.Entity;

namespace AutomatedTellerMachine.Models
{
    public interface IApplicationDbContext
    {
        IDbSet<CheckingAccountModel> CheckingAccountModels { get; set; }

        IDbSet<Transaction> Transactions { get; set; }

        int SaveChanges();
        
    }
}