using System;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class Authorization : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Authorization()
        {
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            Login = loginTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            Password = passwordTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Login;
            label5.Text = Password;
        }
    }
}
