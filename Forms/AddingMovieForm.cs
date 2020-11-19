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
    public partial class AddingMovieForm : Form
    {
        private int ImageName { get; set; }

        public AddingMovieForm(int indexImage)
        {
            InitializeComponent();

            ImageName = indexImage;

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

        }
    }
}
