using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class AssortmentForm : Form
    {
        public DataSet dataSet;

        public AssortmentForm()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile($@"{Application.StartupPath}\FilmsImage\0.jpeg");
        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.cinemaDataBaseDataSet.Films);
            dataSet = this.cinemaDataBaseDataSet;
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
                pictureBox1.Image = Image.FromFile($@"{Application.StartupPath}\FilmsImage\{imageIndex}.jpeg"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexImage = Convert.ToInt32(AssortmentTable.Rows[AssortmentTable.Rows.Count - 2].Cells[0].Value);
            new AddingMovieForm(indexImage).ShowDialog();
        }
    }
}