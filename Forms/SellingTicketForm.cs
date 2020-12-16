using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class SellingTicketForm : Form
    {
        private string ClientFIO { get; set; }
        private int Discount { get; set; }
        private string FilmName { get; set; }
        private int Price { get; set; }
        private string Director { get; set; }
        private string Country { get; set; }
        private int NumberTicket { get; set; }
        private bool IsVIP { get; set; }
        private bool IsStudy { get; set; }
        private string Notes { get; set; }
        private string Login { get; set; }

        public SellingTicketForm(string login)
        {
            InitializeComponent();

            DataGridViewControll gridViewControll = new DataGridViewControll();
            gridViewControll.Update(clientsDataGridView, "Clients");
            gridViewControll.Update(filmsDataGridView, "Films");
            Login = login;
        }

        private void SellingTicketForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet2.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.cinemaDataBaseDataSet2.Films);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet1.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.cinemaDataBaseDataSet1.Clients);
        }

        private void clientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tempSTR = " ";
            for (int i = 1; i <= 3; i++)
            {
                tempSTR += clientsDataGridView[i, e.RowIndex].Value.ToString();
                tempSTR += " ";
            }

            Discount = Convert.ToInt32(clientsDataGridView[7, e.RowIndex].Value);

            ClientFIO = tempSTR;
            selectClientLabel.Text = ClientFIO;

            tempSTR = "";
        }

        private void filmsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FilmName = filmsDataGridView[1, e.RowIndex].Value.ToString();
                Price = Convert.ToInt32(filmsDataGridView[3, e.RowIndex].Value);
                Director = filmsDataGridView[4, e.RowIndex].Value.ToString();
                Country = filmsDataGridView[5, e.RowIndex].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя выбрать!", "Внимание!");
            }

            selectFilmLabel.Text = FilmName;
        }

        private void ready_Click(object sender, EventArgs e)
        {
            //TODO: написать статистику
            Statistics statistics = new Statistics(Login);

            try
            {
                NumberTicket = int.Parse(numberTicketTextBox.Text);
                IsVIP = vipCheckBox.Checked;
                IsStudy = studyDiscountcheckBox.Checked;
                Notes = notesTextBox.Text;
            }

            catch (Exception)
            {
                MessageBox.Show("Нельзя выбрать!", "Внимание!");
            }

            new Ticket(ClientFIO, Discount, FilmName, Price, Director, Country, NumberTicket, IsVIP, IsStudy, Notes).Print();
            MessageBox.Show("Билеты занесены в таблицу!\nГотово к печати!", "Готово!");
        }
    }
}
