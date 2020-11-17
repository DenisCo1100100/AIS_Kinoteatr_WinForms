using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    class Authentication : BaseConection
    {
        private string loadLogin;
        private string loadPassword;

        private OleDbConnection dbConnection;

        public Authentication(string login, string password) 
            : base(login, password) {}

        public override void Execute()
        {
            dbConnection = new OleDbConnection($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\RegisteredUsers.mdb;");
            dbConnection.Open();

            string query = $"SELECT * FROM Users WHERE Login = '{Login}' AND Password = '{Password}'";
            OleDbCommand command = new OleDbCommand(query, dbConnection);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                loadLogin = reader.GetString(1);
                loadPassword = reader.GetString(2);
                Position = reader.GetString(3);
                FullName = reader.GetString(4);
            }

            dbConnection.Close();
            reader.Close();
        }

        public void RunAuthentication()
        {
            if (Login != null && Login == loadLogin)
            {
                CinemaForm cinema = new CinemaForm(Login, FullName, Position);
                cinema.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не зарегистрирован!", "Внимание!");
            }
        }
    }
}
