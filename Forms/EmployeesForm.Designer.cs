
namespace AIS_Kinoteatr
{
    partial class EmployeesForm
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
            this.components = new System.ComponentModel.Container();
            this.employees = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataBaseDataSet1 = new AIS_Kinoteatr.CinemaDataBaseDataSet1();
            this.cinemaDataBaseDataSet = new AIS_Kinoteatr.CinemaDataBaseDataSet();
            this.cinemaDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new AIS_Kinoteatr.CinemaDataBaseDataSet1TableAdapters.EmployeesTableAdapter();
            this.registeredUsersDataSet = new AIS_Kinoteatr.RegisteredUsersDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new AIS_Kinoteatr.RegisteredUsersDataSetTableAdapters.UsersTableAdapter();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employees
            // 
            this.employees.AutoGenerateColumns = false;
            this.employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.functionDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.pasportNumberDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.employees.DataSource = this.usersBindingSource;
            this.employees.Location = new System.Drawing.Point(12, 12);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(776, 317);
            this.employees.TabIndex = 0;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.cinemaDataBaseDataSet1;
            // 
            // cinemaDataBaseDataSet1
            // 
            this.cinemaDataBaseDataSet1.DataSetName = "CinemaDataBaseDataSet1";
            this.cinemaDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemaDataBaseDataSet
            // 
            this.cinemaDataBaseDataSet.DataSetName = "CinemaDataBaseDataSet";
            this.cinemaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemaDataBaseDataSetBindingSource
            // 
            this.cinemaDataBaseDataSetBindingSource.DataSource = this.cinemaDataBaseDataSet;
            this.cinemaDataBaseDataSetBindingSource.Position = 0;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // registeredUsersDataSet
            // 
            this.registeredUsersDataSet.DataSetName = "RegisteredUsersDataSet";
            this.registeredUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.registeredUsersDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 58;
            // 
            // functionDataGridViewTextBoxColumn
            // 
            this.functionDataGridViewTextBoxColumn.DataPropertyName = "Function";
            this.functionDataGridViewTextBoxColumn.HeaderText = "Function";
            this.functionDataGridViewTextBoxColumn.Name = "functionDataGridViewTextBoxColumn";
            this.functionDataGridViewTextBoxColumn.Width = 73;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // pasportNumberDataGridViewTextBoxColumn
            // 
            this.pasportNumberDataGridViewTextBoxColumn.DataPropertyName = "PasportNumber";
            this.pasportNumberDataGridViewTextBoxColumn.HeaderText = "PasportNumber";
            this.pasportNumberDataGridViewTextBoxColumn.Name = "pasportNumberDataGridViewTextBoxColumn";
            this.pasportNumberDataGridViewTextBoxColumn.Width = 105;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 51;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 70;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employees);
            this.Name = "EmployeesForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.BindingSource cinemaDataBaseDataSetBindingSource;
        private CinemaDataBaseDataSet cinemaDataBaseDataSet;
        private CinemaDataBaseDataSet1 cinemaDataBaseDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private CinemaDataBaseDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private RegisteredUsersDataSet registeredUsersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private RegisteredUsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}