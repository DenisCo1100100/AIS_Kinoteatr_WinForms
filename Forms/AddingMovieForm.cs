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
            
            string imageIndex = ImageName.ToString();
            int price = Convert.ToInt32(priceTextBox.Text);

            string request = $"INSERT INTO Films ([Код], [Название], [Описание], [Цена], [Режиссёр], [Страна]) VALUES (" +
                $"'" + imageIndex + "'," +
                " '" + nameTextBox.Text + "'," +
                " '" + descriptRichBox.Text + "'," +
                " '" + price + "'," +
                " '" + directorTextBox.Text + "'," +
                " '" + CountryTextBox.Text + "')";

            TableMenager moviesTable = new TableMenager();
            moviesTable.ExecuteRequest(request);

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
