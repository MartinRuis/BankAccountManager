using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountManager.Interfaces;
using BankAccountManager.DAL.Contexts;

namespace BankAccountManager.DAL
{
    public class ExpensesRepository
    {
        private IExpensesContext context;

        public ExpensesRepository()
        {
            this.context = new ExpensesContextMemory();
        }

        public ExpensesRepository(IExpensesContext context)
        {
            this.context = context;
        }

        public IEnumerable<IExpense> GetAllExpenses() => context.GetAllExpenses();

        public void AddExpense(IExpense expense) => context.AddExpense(expense);
    }
}
