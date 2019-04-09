using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountManager.Interfaces;

namespace BankAccountManager.Models
{
    public class Expense : IExpense
    {
        private string expense_description;
        public string ExpenseDescription
        {
            get { return expense_description; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Expense description must be set.");
                }
                expense_description = value;
            }
        }

        public decimal ExpenseAmount { get; private set; }
        public ExpenseType Type { get; private set; }
        public DateTime ExpenseDate { get; private set; }

        public Expense(string expense_discription, decimal expense_amount, ExpenseType type, DateTime expense_date)
        {
            ExpenseDescription = expense_description;
            ExpenseAmount = expense_amount;
            Type = type;
            ExpenseDate = expense_date;
        }

        public void SetTimestampToNow()
        {
            ExpenseDate = DateTime.Now.Date;
        }
    }
}
