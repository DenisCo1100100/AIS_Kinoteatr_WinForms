using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    class Authentication
    {
        private string Login { get; set; }
        private string Password { get; set; }
        private string Position { get; set; }
        private string FullName { get; set; }


        private readonly OleDbConnection dbConnection;

        public Authentication(string login, string password)
        {
            dbConnection = new OleDbConnection($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\RegisteredUsers.mdb;");
            dbConnection.Open();

            string query = $"SELECT * FROM Users WHERE Login = '{login}' AND Password = '{password}'";
            OleDbCommand command = new OleDbCommand(query, dbConnection);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                Login = reader.GetString(1);
                Password = reader.GetString(2);
                Position = reader.GetString(3);
                FullName = reader.GetString(4);
            } 

            dbConnection.Close();
            reader.Close();
        }

        public void RunAuthentication()
        {
            if (Login != null)
            {
                CinemaForm cinema = new CinemaForm(Login, FullName, Position);
                cinema.Show();
            }
            else
            {
                MessageBox.Show($"Аккаунт не зарегистрирован!", "Внимание!");
            }
        }
    }
}
