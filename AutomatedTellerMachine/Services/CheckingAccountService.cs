using AutomatedTellerMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Services
{
    public class CheckingAccountService
    {
        private IApplicationDbContext db;

        public CheckingAccountService(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastname, string userId, decimal initialBalance)
        {
            var accountNumber = (123456 + db.CheckingAccountModels.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccountModel
            {
                FirstName = firstName,
                LastName = lastname,
                AccountNumber = accountNumber,
                Balance = initialBalance,
                ApplicationUserId = userId
            };
            db.CheckingAccountModels.Add(checkingAccount);
            db.SaveChanges();
        }

        public void UpdateBalance(int checkingAccountId)
        {
            var checkingAccount = db.CheckingAccountModels.Where(c => c.Id == checkingAccountId).First();
            checkingAccount.Balance = db.Transactions.Where(c => c.CheckingAccountId == checkingAccountId).Sum( c => c.Amount);

            db.SaveChanges();
        }
    }
}