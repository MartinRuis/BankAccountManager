using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager.Interfaces
{
    public interface IExpense
    {
        decimal ExpenseAmount { get; }
        ExpenseType Type { get; }
        string ExpenseDescription { get; }

        DateTime ExpenseDate { get; }
        void SetTimestampToNow();
    }
}
