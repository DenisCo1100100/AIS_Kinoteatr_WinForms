using System;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class AddingClientsForm : Form
    {
        private DataGridView DataGrid { get; set; }

        public AddingClientsForm()
        {
            InitializeComponent();
        }

        public AddingClientsForm(DataGridView dataGrid)
        {
            InitializeComponent();
            DataGrid = dataGrid;
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(discountTextBox.Text);
            int pasport = Convert.ToInt32(pasportTextBox.Text);

            //TODO: Дописть добавление клиента
            string cmdText = $"INSERT INTO Clients ([Фамилия], [Имя], [Отчество], [Адрес], [Паспорт], [Дата регистрации], [Предоставить скидку]) VALUES (" +
                $"'"+ secondNameTextBox.Text +"'," +
                " '"+ firstNameTextBox.Text +"'," +
                " '"+ patronymicTextBox.Text +"'," +
                " '"+ addressTextBox.Text +"'," +
                " '"+ pasport +"'," +
                " '"+ DateTime.Now +"'," +
                " '"+ discount +"')";

            TableMenager moviesTable = new TableMenager();
            moviesTable.ExecuteRequest(cmdText);
        }

        private void AddingClientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridViewControll gridViewControll = new DataGridViewControll();
            gridViewControll.Update(DataGrid, "Clients");
        }
    }
}
