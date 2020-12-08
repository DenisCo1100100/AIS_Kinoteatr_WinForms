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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet1.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.cinemaDataBaseDataSet1.Clients);
        }

        private void addClient_Click(object sender, EventArgs e)
        {

        }
    }
}
