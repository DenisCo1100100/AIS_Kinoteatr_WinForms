﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class AddingMovieForm : Form
    {
        private int ImageName { get; set; }
        private DataGridView AssortmentDataGrid { get; set; }

        public AddingMovieForm(int indexImage, DataGridView assortmentDataGrid)
        {
            InitializeComponent();

            ImageName = indexImage + 1;
            AssortmentDataGrid = assortmentDataGrid;

            openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
            openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
            openFileDialog1.FileOk += OpenFileDialog1_FileOk;
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save($@"{Application.StartupPath}\FilmsImage\{ImageName}.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            MoviesTableMenager moviesTable = new MoviesTableMenager(
                nameTextBox.Text, 
                directorTextBox.Text, 
                CountryTextBox.Text,
                Convert.ToInt32(priceTextBox.Text),
                descriptRichBox.Text,
                ImageName.ToString());

            moviesTable.Add();
        }

        OleDbDataAdapter adap = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        private void AddingMovieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataSet dataSet = new DataSet(); 
            OleDbConnection con = new OleDbConnection($@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = CinemaDataBase.mdb;");
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "Select * from Films";
            con.Open();
            adap.SelectCommand = command;
            adap.Fill(dataSet);
            dt = dataSet.Tables[0];
            AssortmentDataGrid.DataSource = dt;
            con.Close();
        }
    }
}
