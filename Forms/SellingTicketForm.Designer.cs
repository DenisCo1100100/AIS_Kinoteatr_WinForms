
namespace AIS_Kinoteatr
{
    partial class SellingTicketForm
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
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предоставитьСкидкуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataBaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataBaseDataSet1 = new AIS_Kinoteatr.CinemaDataBaseDataSet1();
            this.filmsDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссёрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataBaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataBaseDataSet2 = new AIS_Kinoteatr.CinemaDataBaseDataSet2();
            this.numberTicketTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vipCheckBox = new System.Windows.Forms.CheckBox();
            this.clientsTableAdapter = new AIS_Kinoteatr.CinemaDataBaseDataSet1TableAdapters.ClientsTableAdapter();
            this.filmsTableAdapter = new AIS_Kinoteatr.CinemaDataBaseDataSet2TableAdapters.FilmsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studyDiscountcheckBox = new System.Windows.Forms.CheckBox();
            this.ready = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.selectClientLabel = new System.Windows.Forms.Label();
            this.selectFilmLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.датаРегистрацииDataGridViewTextBoxColumn,
            this.предоставитьСкидкуDataGridViewTextBoxColumn});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(13, 31);
            this.clientsDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(895, 205);
            this.clientsDataGridView.TabIndex = 0;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellClick);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            // 
            // датаРегистрацииDataGridViewTextBoxColumn
            // 
            this.датаРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.Name = "датаРегистрацииDataGridViewTextBoxColumn";
            // 
            // предоставитьСкидкуDataGridViewTextBoxColumn
            // 
            this.предоставитьСкидкуDataGridViewTextBoxColumn.DataPropertyName = "Предоставить скидку";
            this.предоставитьСкидкуDataGridViewTextBoxColumn.HeaderText = "Предоставить скидку";
            this.предоставитьСкидкуDataGridViewTextBoxColumn.Name = "предоставитьСкидкуDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.cinemaDataBaseDataSet1BindingSource;
            // 
            // cinemaDataBaseDataSet1BindingSource
            // 
            this.cinemaDataBaseDataSet1BindingSource.DataSource = this.cinemaDataBaseDataSet1;
            this.cinemaDataBaseDataSet1BindingSource.Position = 0;
            // 
            // cinemaDataBaseDataSet1
            // 
            this.cinemaDataBaseDataSet1.DataSetName = "CinemaDataBaseDataSet1";
            this.cinemaDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsDataGridView
            // 
            this.filmsDataGridView.AutoGenerateColumns = false;
            this.filmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.режиссёрDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn});
            this.filmsDataGridView.DataSource = this.filmsBindingSource;
            this.filmsDataGridView.Location = new System.Drawing.Point(13, 266);
            this.filmsDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filmsDataGridView.Name = "filmsDataGridView";
            this.filmsDataGridView.Size = new System.Drawing.Size(895, 196);
            this.filmsDataGridView.TabIndex = 1;
            this.filmsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmsDataGridView_CellClick);
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // режиссёрDataGridViewTextBoxColumn
            // 
            this.режиссёрDataGridViewTextBoxColumn.DataPropertyName = "Режиссёр";
            this.режиссёрDataGridViewTextBoxColumn.HeaderText = "Режиссёр";
            this.режиссёрDataGridViewTextBoxColumn.Name = "режиссёрDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.cinemaDataBaseDataSet2BindingSource;
            // 
            // cinemaDataBaseDataSet2BindingSource
            // 
            this.cinemaDataBaseDataSet2BindingSource.DataSource = this.cinemaDataBaseDataSet2;
            this.cinemaDataBaseDataSet2BindingSource.Position = 0;
            // 
            // cinemaDataBaseDataSet2
            // 
            this.cinemaDataBaseDataSet2.DataSetName = "CinemaDataBaseDataSet2";
            this.cinemaDataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberTicketTextBox
            // 
            this.numberTicketTextBox.Location = new System.Drawing.Point(128, 470);
            this.numberTicketTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberTicketTextBox.Name = "numberTicketTextBox";
            this.numberTicketTextBox.Size = new System.Drawing.Size(36, 23);
            this.numberTicketTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер билета:";
            // 
            // vipCheckBox
            // 
            this.vipCheckBox.AutoSize = true;
            this.vipCheckBox.Location = new System.Drawing.Point(252, 470);
            this.vipCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vipCheckBox.Name = "vipCheckBox";
            this.vipCheckBox.Size = new System.Drawing.Size(85, 21);
            this.vipCheckBox.TabIndex = 4;
            this.vipCheckBox.Text = "VIP ложа";
            this.vipCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выбор клиента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выбор фильма:";
            // 
            // studyDiscountcheckBox
            // 
            this.studyDiscountcheckBox.AutoSize = true;
            this.studyDiscountcheckBox.Location = new System.Drawing.Point(409, 470);
            this.studyDiscountcheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studyDiscountcheckBox.Name = "studyDiscountcheckBox";
            this.studyDiscountcheckBox.Size = new System.Drawing.Size(120, 21);
            this.studyDiscountcheckBox.TabIndex = 11;
            this.studyDiscountcheckBox.Text = "Студенческий";
            this.studyDiscountcheckBox.UseVisualStyleBackColor = true;
            // 
            // ready
            // 
            this.ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ready.Location = new System.Drawing.Point(333, 509);
            this.ready.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(213, 38);
            this.ready.TabIndex = 12;
            this.ready.Text = "Готово";
            this.ready.UseVisualStyleBackColor = true;
            this.ready.Click += new System.EventHandler(this.ready_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 471);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Примечания:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(690, 468);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(219, 23);
            this.notesTextBox.TabIndex = 13;
            // 
            // selectClientLabel
            // 
            this.selectClientLabel.AutoSize = true;
            this.selectClientLabel.Location = new System.Drawing.Point(115, 11);
            this.selectClientLabel.Name = "selectClientLabel";
            this.selectClientLabel.Size = new System.Drawing.Size(90, 17);
            this.selectClientLabel.TabIndex = 15;
            this.selectClientLabel.Text = "Не выбрано!";
            // 
            // selectFilmLabel
            // 
            this.selectFilmLabel.AutoSize = true;
            this.selectFilmLabel.Location = new System.Drawing.Point(115, 246);
            this.selectFilmLabel.Name = "selectFilmLabel";
            this.selectFilmLabel.Size = new System.Drawing.Size(90, 17);
            this.selectFilmLabel.TabIndex = 16;
            this.selectFilmLabel.Text = "Не выбрано!";
            // 
            // SellingTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 559);
            this.Controls.Add(this.selectFilmLabel);
            this.Controls.Add(this.selectClientLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.ready);
            this.Controls.Add(this.studyDiscountcheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vipCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTicketTextBox);
            this.Controls.Add(this.filmsDataGridView);
            this.Controls.Add(this.clientsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SellingTicketForm";
            this.Text = "Продажа билетов";
            this.Load += new System.EventHandler(this.SellingTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataBaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridView filmsDataGridView;
        private System.Windows.Forms.TextBox numberTicketTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox vipCheckBox;
        private CinemaDataBaseDataSet1 cinemaDataBaseDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private CinemaDataBaseDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предоставитьСкидкуDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cinemaDataBaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource cinemaDataBaseDataSet2BindingSource;
        private CinemaDataBaseDataSet2 cinemaDataBaseDataSet2;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private CinemaDataBaseDataSet2TableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссёрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox studyDiscountcheckBox;
        private System.Windows.Forms.Button ready;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label selectClientLabel;
        private System.Windows.Forms.Label selectFilmLabel;
    }
}