﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountManager.Interfaces;

namespace BankAccountManager.DAL.Contexts
{
    public interface IExpensesContext
    {
        IEnumerable<IExpense> GetAllExpenses();

        void AddExpense(IExpense expense);
    }
}
