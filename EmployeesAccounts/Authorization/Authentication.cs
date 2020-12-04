using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{//TODO : Дописать проверку пороля
    class Authentication : BaseConection
    {
        private string loadLogin;

        public Authentication(string login, string password) 
            : base(login, password) {}

        public void Execute()
        {
            OleDbConnect.Open();

            string query = $"SELECT * FROM Employees WHERE Логин = '{Login}' AND Пароль = '{Password}'";
            OleDbCommand command = new OleDbCommand(query, OleDbConnect);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                loadLogin = reader.GetString(0);
                Position = reader.GetString(2);
                FullName = reader.GetString(3);
            }

            OleDbConnect.Close();
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
