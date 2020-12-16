using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_Kinoteatr
{
    class Statistics
    {
        private int SellTickets { get; set; }
        private int RegClients { get; set; }
        private int Bonuses { get; set; }
        private double Profit { get; set; }
        private double Salary { get; set; }
        private string Login { get; set; }
        private string request;

        private TableMenager tableMenager;

        public Statistics(string login)
        {
            tableMenager = new TableMenager();
            Login = login;
        }

        public void AddSellTicket(Ticket ticket)
        {
            
            SellTickets++;
            Bonuses += 5;

            request = "UPDATE Employees SET Проданные_билеты = Проданные_билеты + 1, Полученная_прибыль = Полученая_прибыль + '"+ ticket.Price +"' WHERE Логин = '"+ Login +"';";
            tableMenager.ExecuteRequest(request);
        }

        public void AddRegistrationClient()
        {
            RegClients++;
            Bonuses += 10;

            request = "UPDATE Employees SET Зарег_пользователи = Зарег_пользователи + 1 WHERE Логин = '" + Login +"';";
            tableMenager.ExecuteRequest(request);
            ColculateSalary();
        }

        public void ColculateSalary()
        {

            request = "SELECT Проданные_билеты, Зарег_пользователи, Полученная_прибыль FROM Employees WHERE Логин = "+ Login +"";
            string[] employeesStat= tableMenager.SelectInDB(request);

        }
    }
}
