using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager.Models
{
    public class User
    {
        public int ID { get; private set; }
        public string Initials { get; private set; }
        public string First_Name { get; private set; }
        public string Last_Name { get; private set; }
        public string E_Mail { get; private set; }
    }
}
