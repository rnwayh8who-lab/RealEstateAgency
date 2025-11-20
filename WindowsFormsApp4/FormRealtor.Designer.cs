namespace WindowsFormsApp4
{
    partial class FormRealtor
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.txtDocPath = new System.Windows.Forms.TextBox();
            this.txtDocTitle = new System.Windows.Forms.TextBox();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnSetAccepted = new System.Windows.Forms.Button();
            this.btnSetPaid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.comboClients = new System.Windows.Forms.ComboBox();
            this.comboProperty = new System.Windows.Forms.ComboBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewDocs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(555, 460);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(162, 115);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(99, 46);
            this.btnCreateClient.TabIndex = 16;
            this.btnCreateClient.Text = "Создать";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(34, 63);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 20);
            this.txtClientName.TabIndex = 17;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(162, 63);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(100, 20);
            this.txtClientPhone.TabIndex = 18;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(289, 63);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(100, 20);
            this.txtClientEmail.TabIndex = 19;
            // 
            // txtDocPath
            // 
            this.txtDocPath.Location = new System.Drawing.Point(219, 208);
            this.txtDocPath.Name = "txtDocPath";
            this.txtDocPath.Size = new System.Drawing.Size(100, 20);
            this.txtDocPath.TabIndex = 21;
            // 
            // txtDocTitle
            // 
            this.txtDocTitle.Location = new System.Drawing.Point(91, 208);
            this.txtDocTitle.Name = "txtDocTitle";
            this.txtDocTitle.Size = new System.Drawing.Size(100, 20);
            this.txtDocTitle.TabIndex = 20;
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Location = new System.Drawing.Point(35, 248);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(99, 46);
            this.btnAddDoc.TabIndex = 22;
            this.btnAddDoc.Text = "Добавить";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnSetAccepted
            // 
            this.btnSetAccepted.Location = new System.Drawing.Point(162, 248);
            this.btnSetAccepted.Name = "btnSetAccepted";
            this.btnSetAccepted.Size = new System.Drawing.Size(99, 46);
            this.btnSetAccepted.TabIndex = 23;
            this.btnSetAccepted.Text = "Принят";
            this.btnSetAccepted.UseVisualStyleBackColor = true;
            this.btnSetAccepted.Click += new System.EventHandler(this.btnSetAccepted_Click);
            // 
            // btnSetPaid
            // 
            this.btnSetPaid.Location = new System.Drawing.Point(289, 248);
            this.btnSetPaid.Name = "btnSetPaid";
            this.btnSetPaid.Size = new System.Drawing.Size(99, 46);
            this.btnSetPaid.TabIndex = 24;
            this.btnSetPaid.Text = "Оплачен";
            this.btnSetPaid.UseVisualStyleBackColor = true;
            this.btnSetPaid.Click += new System.EventHandler(this.btnSetPaid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(555, 460);
            this.dataGridViewClients.TabIndex = 26;
            // 
            // comboClients
            // 
            this.comboClients.FormattingEnabled = true;
            this.comboClients.Location = new System.Drawing.Point(35, 352);
            this.comboClients.Name = "comboClients";
            this.comboClients.Size = new System.Drawing.Size(121, 21);
            this.comboClients.TabIndex = 27;
            // 
            // comboProperty
            // 
            this.comboProperty.FormattingEnabled = true;
            this.comboProperty.Location = new System.Drawing.Point(182, 352);
            this.comboProperty.Name = "comboProperty";
            this.comboProperty.Size = new System.Drawing.Size(121, 21);
            this.comboProperty.TabIndex = 28;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(119, 390);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(99, 46);
            this.btnCreateOrder.TabIndex = 29;
            this.btnCreateOrder.Text = "Создать";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 46);
            this.button2.TabIndex = 30;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(598, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 498);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewDocs);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(567, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Документы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDocs
            // 
            this.dataGridViewDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocs.Location = new System.Drawing.Point(9, 3);
            this.dataGridViewDocs.Name = "dataGridViewDocs";
            this.dataGridViewDocs.Size = new System.Drawing.Size(555, 460);
            this.dataGridViewDocs.TabIndex = 32;
            this.dataGridViewDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDocuments_CellContentClick);
            // 
            // FormRealtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.comboProperty);
            this.Controls.Add(this.comboClients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetPaid);
            this.Controls.Add(this.btnSetAccepted);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.txtDocPath);
            this.Controls.Add(this.txtDocTitle);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.txtClientPhone);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.btnCreateClient);
            this.Name = "FormRealtor";
            this.Text = "FormRealtor";
            this.Load += new System.EventHandler(this.FormRealtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.TextBox txtDocPath;
        private System.Windows.Forms.TextBox txtDocTitle;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Button btnSetAccepted;
        private System.Windows.Forms.Button btnSetPaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.ComboBox comboClients;
        private System.Windows.Forms.ComboBox comboProperty;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewDocs;
    }
}