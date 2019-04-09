using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager.Interfaces
{
    public interface IUser
    {
        int ID { get; }
        string Initials { get; }
        string First_Name { get; }
        string Last_Name { get; }
        string E_Mail { get; }

        void SetUserID(int id);
    }
}
