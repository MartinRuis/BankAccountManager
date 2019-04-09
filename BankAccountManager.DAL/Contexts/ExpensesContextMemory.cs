using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountManager.Interfaces;

namespace BankAccountManager.DAL.Contexts
{
    public class ExpensesContextMemory : IExpensesContext
    {
        private static List<IExpense> expenses = new List<IExpense>();

        public ExpensesContextMemory()
        {
            //Here all expenses are created in the programs memory
        }

        public void AddExpense(IExpense expense)
        {
            expenses.Add(expense);
        }

        public IEnumerable<IExpense> GetAllExpenses()
        {
            return expenses;
        }
    }
}
