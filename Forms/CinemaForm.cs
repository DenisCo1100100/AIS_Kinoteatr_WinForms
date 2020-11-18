using System;
using System.Windows.Forms;

namespace AIS_Kinoteatr
{
    public partial class CinemaForm : Form
    {
        private string Login { get; set; }
        private string FullName { get; set; }
        private string Positions { get; set; }

        public CinemaForm(string login, string fullName, string position)
        {
            InitializeComponent();

            Login = login;
            FullName = fullName;
            Positions = position;

            FillUserDate();
        }

        private void FillUserDate()
        {
            groupBox1.Text = Login;

            string[] fullNameSplit = FullName.Split();
            userNameLable.Text = $"Фамилия: {fullNameSplit[0]}\n" +
                $"Имя: {fullNameSplit[1]}\n" +
                $"Отчество: {fullNameSplit[2]}\n" +
                $"Должность: {Positions}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
