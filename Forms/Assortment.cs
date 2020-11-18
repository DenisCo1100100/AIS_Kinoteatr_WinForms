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
    public partial class Assortment : Form
    {
        public Assortment()
        {
            InitializeComponent();
        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.cinemaDataBaseDataSet.Films);

            //$@"{Application.StartupPath}\FilmsImage\{imageColum.Index}.jpg"

        }

        private void AssortmentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (AssortmentTable.Rows.Count - 2) >= e.RowIndex)
            {
                pictureBox1.Image = Image.FromFile($@"{Application.StartupPath}\FilmsImage\{e.RowIndex}.jpg");
            }
        }
    }
}
