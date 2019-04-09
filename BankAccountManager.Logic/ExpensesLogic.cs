using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountManager.Models;
using BankAccountManager.Interfaces;
using BankAccountManager.DAL;

namespace BankAccountManager.Logic
{
    public class ExpensesLogic
    {
        private ExpensesRepository expenses_repo = new ExpensesRepository();
        private IUser user;

        public IEnumerable<IExpense> GetAllExpensesByMonth()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IExpense> GetAllExpensesByQuarter()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IExpense> GetAllExpensesByYear()
        {
            throw new NotImplementedException();
        }

        public void AddExpense()
        {
            throw new NotImplementedException();
        }

        public void DeleteExpense()
        {
            throw new NotImplementedException();
        }
    }
}
