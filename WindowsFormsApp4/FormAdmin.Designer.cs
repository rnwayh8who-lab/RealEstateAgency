namespace WindowsFormsApp4
{
    partial class FormAdmin
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.btnSetRealtor = new System.Windows.Forms.Button();
            this.btnSetLawyer = new System.Windows.Forms.Button();
            this.comboShift = new System.Windows.Forms.ComboBox();
            this.btnSetShift = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(619, 12);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(558, 503);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(502, 469);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 46);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(244, 236);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(99, 46);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.Location = new System.Drawing.Point(102, 305);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(99, 46);
            this.btnFireEmployee.TabIndex = 3;
            this.btnFireEmployee.Text = "Уволить";
            this.btnFireEmployee.UseVisualStyleBackColor = true;
            this.btnFireEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetRealtor
            // 
            this.btnSetRealtor.Location = new System.Drawing.Point(244, 305);
            this.btnSetRealtor.Name = "btnSetRealtor";
            this.btnSetRealtor.Size = new System.Drawing.Size(99, 46);
            this.btnSetRealtor.TabIndex = 4;
            this.btnSetRealtor.Text = "Назначить риелтором";
            this.btnSetRealtor.UseVisualStyleBackColor = true;
            this.btnSetRealtor.Click += new System.EventHandler(this.btnSetRealtor_Click);
            // 
            // btnSetLawyer
            // 
            this.btnSetLawyer.Location = new System.Drawing.Point(397, 305);
            this.btnSetLawyer.Name = "btnSetLawyer";
            this.btnSetLawyer.Size = new System.Drawing.Size(99, 46);
            this.btnSetLawyer.TabIndex = 5;
            this.btnSetLawyer.Text = "Назначить юристом";
            this.btnSetLawyer.UseVisualStyleBackColor = true;
            this.btnSetLawyer.Click += new System.EventHandler(this.btnSetLawyer_Click);
            // 
            // comboShift
            // 
            this.comboShift.FormattingEnabled = true;
            this.comboShift.Location = new System.Drawing.Point(480, 380);
            this.comboShift.Name = "comboShift";
            this.comboShift.Size = new System.Drawing.Size(121, 21);
            this.comboShift.TabIndex = 6;
            // 
            // btnSetShift
            // 
            this.btnSetShift.Location = new System.Drawing.Point(480, 407);
            this.btnSetShift.Name = "btnSetShift";
            this.btnSetShift.Size = new System.Drawing.Size(121, 46);
            this.btnSetShift.TabIndex = 7;
            this.btnSetShift.Text = "Назначить смену";
            this.btnSetShift.UseVisualStyleBackColor = true;
            this.btnSetShift.Click += new System.EventHandler(this.btnSetShift_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 197);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(131, 197);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxRole.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(257, 197);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(382, 197);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(502, 197);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 12;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(503, 26);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(99, 46);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 26);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(142, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 46);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 46);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(382, 26);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(100, 46);
            this.btnDeactivate.TabIndex = 17;
            this.btnDeactivate.Text = "Деактивировать";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnSetShift);
            this.Controls.Add(this.comboShift);
            this.Controls.Add(this.btnSetLawyer);
            this.Controls.Add(this.btnSetRealtor);
            this.Controls.Add(this.btnFireEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.Button btnSetRealtor;
        private System.Windows.Forms.Button btnSetLawyer;
        private System.Windows.Forms.ComboBox comboShift;
        private System.Windows.Forms.Button btnSetShift;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button button1;
    }
}