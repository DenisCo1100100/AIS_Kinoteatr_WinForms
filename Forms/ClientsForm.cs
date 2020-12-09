using System;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class ClientsForm : Form
    {
        private int SelectRow { get; set; }
        private DataGridViewControll gridViewControll;
        public ClientsForm()
        {
            InitializeComponent();
            gridViewControll = new DataGridViewControll();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet1.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.cinemaDataBaseDataSet1.Clients);

            gridViewControll.Update(clientsGridView, "Clients");
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            new AddingClientsForm(clientsGridView).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string request = $@"Delete * From Clients WHERE код = {clientsGridView[0, SelectRow].Value}";
                new TableMenager().ExecuteRequest(request);

                gridViewControll.Update(clientsGridView, "Clients");
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить!", "Внимание");
            }
        }

        private void clientsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
        }
    }
}
