
namespace AIS_Kinoteatr
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.positions = new System.Windows.Forms.ComboBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.patronomic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPasportNumb = new System.Windows.Forms.Label();
            this.pasportNumber = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.labelAccsesLvl = new System.Windows.Forms.Label();
            this.accsesLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(206, 15);
            this.lastName.Margin = new System.Windows.Forms.Padding(6);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(247, 30);
            this.lastName.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(206, 57);
            this.firstName.Margin = new System.Windows.Forms.Padding(6);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(247, 30);
            this.firstName.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(206, 141);
            this.login.Margin = new System.Windows.Forms.Padding(6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(247, 30);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(206, 183);
            this.password.Margin = new System.Windows.Forms.Padding(6);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(247, 30);
            this.password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Должность";
            // 
            // positions
            // 
            this.positions.FormattingEnabled = true;
            this.positions.Items.AddRange(new object[] {
            "Junior",
            "Midle",
            "FullStack",
            "Senior"});
            this.positions.Location = new System.Drawing.Point(206, 222);
            this.positions.Margin = new System.Windows.Forms.Padding(6);
            this.positions.Name = "positions";
            this.positions.Size = new System.Drawing.Size(247, 33);
            this.positions.TabIndex = 10;
            this.positions.UseWaitCursor = true;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(67, 433);
            this.buttonRegistration.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(376, 37);
            this.buttonRegistration.TabIndex = 11;
            this.buttonRegistration.Text = "Зарегистрировать";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.button1_Click);
            // 
            // patronomic
            // 
            this.patronomic.Location = new System.Drawing.Point(206, 99);
            this.patronomic.Margin = new System.Windows.Forms.Padding(6);
            this.patronomic.Name = "patronomic";
            this.patronomic.Size = new System.Drawing.Size(247, 30);
            this.patronomic.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Отчество";
            // 
            // labelPasportNumb
            // 
            this.labelPasportNumb.AutoSize = true;
            this.labelPasportNumb.Location = new System.Drawing.Point(27, 270);
            this.labelPasportNumb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPasportNumb.Name = "labelPasportNumb";
            this.labelPasportNumb.Size = new System.Drawing.Size(166, 25);
            this.labelPasportNumb.TabIndex = 15;
            this.labelPasportNumb.Text = "Номер паспорта";
            // 
            // pasportNumber
            // 
            this.pasportNumber.Location = new System.Drawing.Point(206, 270);
            this.pasportNumber.Margin = new System.Windows.Forms.Padding(6);
            this.pasportNumber.Name = "pasportNumber";
            this.pasportNumber.Size = new System.Drawing.Size(247, 30);
            this.pasportNumber.TabIndex = 14;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(104, 317);
            this.labelAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(89, 25);
            this.labelAge.TabIndex = 17;
            this.labelAge.Text = "Возраст";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(206, 312);
            this.age.Margin = new System.Windows.Forms.Padding(6);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(247, 30);
            this.age.TabIndex = 16;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(124, 354);
            this.labelAdres.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(69, 25);
            this.labelAdres.TabIndex = 19;
            this.labelAdres.Text = "Адрес";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(206, 349);
            this.adres.Margin = new System.Windows.Forms.Padding(6);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(247, 30);
            this.adres.TabIndex = 18;
            // 
            // labelAccsesLvl
            // 
            this.labelAccsesLvl.AutoSize = true;
            this.labelAccsesLvl.Location = new System.Drawing.Point(27, 394);
            this.labelAccsesLvl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAccsesLvl.Name = "labelAccsesLvl";
            this.labelAccsesLvl.Size = new System.Drawing.Size(168, 25);
            this.labelAccsesLvl.TabIndex = 21;
            this.labelAccsesLvl.Text = "Уровень доступа";
            // 
            // accsesLevel
            // 
            this.accsesLevel.Location = new System.Drawing.Point(206, 391);
            this.accsesLevel.Margin = new System.Windows.Forms.Padding(6);
            this.accsesLevel.Name = "accsesLevel";
            this.accsesLevel.Size = new System.Drawing.Size(247, 30);
            this.accsesLevel.TabIndex = 20;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 485);
            this.Controls.Add(this.labelAccsesLvl);
            this.Controls.Add(this.accsesLevel);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.age);
            this.Controls.Add(this.labelPasportNumb);
            this.Controls.Add(this.pasportNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patronomic);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.positions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox positions;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TextBox patronomic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPasportNumb;
        private System.Windows.Forms.TextBox pasportNumber;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label labelAccsesLvl;
        private System.Windows.Forms.TextBox accsesLevel;
    }
}