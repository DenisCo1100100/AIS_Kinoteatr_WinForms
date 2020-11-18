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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = lastName.Text + " " + firstName.Text + " " + patronomic.Text;
            Registration registration = new Registration(login.Text, password.Text, fullName, positions.Text);
            MessageBox.Show("ГОТОВО!");
        }
    }
}
