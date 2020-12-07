using System;
using System.ComponentModel;
using System.Drawing;
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

        private void addImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void complite_Click(object sender, EventArgs e)
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

            MessageBox.Show("Фильм добавлен!", "Готово");
            this.Close();
        }

        private void AddingMovieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridViewControll gridViewControll = new DataGridViewControll();
            gridViewControll.Update(AssortmentDataGrid, "Films");
        }
    }
}
