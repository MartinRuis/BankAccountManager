using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountManager.Interfaces;

namespace BankAccountManager.Models
{
    public class User : IUser
    {
        public int ID { get; private set; }
        public string Initials { get; private set; }
        public string First_Name { get; private set; }
        public string Last_Name { get; private set; }
        public string E_Mail { get; private set; }

        public User(string initials, string first_name, string last_name, string e_mail)
        {
            Initials = initials;
            First_Name = first_name;
            Last_Name = last_name;
            E_Mail = e_mail;
        }

        public void SetUserID(int id)
        {
            ID = id;
        }
    }
}
