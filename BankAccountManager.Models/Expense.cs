using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager.Models
{
    public class Expense
    {
        //properties
        public int ExpenseID { get; private set; }
        public decimal ExpenseAmount { get; private set; }
        public ExpenseType Type { get; private set;}
        public string ExpenseDescription { get; private set; }
        public DateTime ExpenseDate { get; private set; }
    }
}
