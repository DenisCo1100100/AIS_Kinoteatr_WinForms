using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_Kinoteatr
{
    abstract class BaseConection
    {
        internal string Login { get; set; }
        internal string Password { get; set; }
        internal string FullName { get; set; }
        internal string Position { get; set; }

        public BaseConection(string login, string password, string fullName = null, string position = null)
        {
            Login = login;
            Password = password;
            FullName = fullName;
            Position = position;

            Execute();
        }

        abstract public void Execute();
    }
}
