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

            pictureBox1.Image = Image.FromFile($@"{Application.StartupPath}\FilmsImage\0.jpg");
        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.cinemaDataBaseDataSet.Films);
        }

        private void AssortmentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int imageIndex = 0;

            if (e.RowIndex >= 0)
            {
                imageIndex = Convert.ToInt32(AssortmentTable[0, e.RowIndex].Value);
            }

            if (imageIndex >= 2) 
            {
                pictureBox1.Image = Image.FromFile($@"{Application.StartupPath}\FilmsImage\{imageIndex}.jpg"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddingMovieForm().ShowDialog();
        }
    }
}
