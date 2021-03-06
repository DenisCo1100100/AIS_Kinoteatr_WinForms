﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class AssortmentForm : Form
    {
        private int SelectRow { get; set; }
        DataGridViewControll gridViewControll;
        public AssortmentForm()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile($@"{Application.StartupPath}\FilmsImage\0.jpeg");
            gridViewControll = new DataGridViewControll();

            gridViewControll.Update(assortmentTable, "Films");
        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataBaseDataSet2.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.cinemaDataBaseDataSet2.Films);
        }

        private void AssortmentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int imageIndex = 0;
            SelectRow = e.RowIndex;

            if (e.RowIndex >= 0 && assortmentTable[0, e.RowIndex].Value.ToString() != "")
            {
                imageIndex = Convert.ToInt32(assortmentTable[0, e.RowIndex].Value);
            }

            if (imageIndex >= 2) 
            {
                pictureBox1.Image = Image.FromFile($@"{Application.StartupPath}\FilmsImage\{imageIndex}.jpeg"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexImage = Convert.ToInt32(assortmentTable.Rows[assortmentTable.Rows.Count - 2].Cells[0].Value);
            new AddingMovieForm(indexImage, assortmentTable).ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            gridViewControll.Update(assortmentTable, "Films");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string request = $@"Delete * From Films WHERE код = {assortmentTable[0, SelectRow].Value}";
                new TableMenager().ExecuteRequest(request);

                gridViewControll.Update(assortmentTable, "Films");
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить", "Внимание!");
            }
        }
    }
}