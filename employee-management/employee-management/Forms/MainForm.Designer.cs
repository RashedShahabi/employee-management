namespace ContactProject.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.welcome_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.date_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.contact_grid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manage_user_button = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_user_button = new System.Windows.Forms.ToolStripMenuItem();
            this.change_password_button = new System.Windows.Forms.ToolStripMenuItem();
            this.manage_contact_button = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_new_contact_button = new System.Windows.Forms.ToolStripMenuItem();
            this.update_contact_button = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_contact_button = new System.Windows.Forms.ToolStripMenuItem();
            this.manage_phones_button = new System.Windows.Forms.ToolStripMenuItem();
            this.confirm_admin_button = new System.Windows.Forms.ToolStripMenuItem();
            this.user_name_text = new System.Windows.Forms.ToolStripTextBox();
            this.user_contacts_combo = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contact_info = new System.Windows.Forms.TextBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_contacts_button = new System.Windows.Forms.ToolStripMenuItem();
            this.confirm_transaction_button = new System.Windows.Forms.ToolStripMenuItem();
            this.search_label = new System.Windows.Forms.ToolStripMenuItem();
            this.manage_pays_button = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contact_grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcome_label,
            this.date_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(982, 30);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // welcome_label
            // 
            this.welcome_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(188, 25);
            this.welcome_label.Text = "toolStripStatusLabel1";
            // 
            // date_label
            // 
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(118, 25);
            this.date_label.Text = "toolStripStatusLabel1";
            // 
            // contact_grid
            // 
            this.contact_grid.AllowUserToAddRows = false;
            this.contact_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contact_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contact_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contact_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.contact_grid.Location = new System.Drawing.Point(23, 201);
            this.contact_grid.Name = "contact_grid";
            this.contact_grid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contact_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contact_grid.RowHeadersVisible = false;
            this.contact_grid.RowHeadersWidth = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contact_grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.contact_grid.Size = new System.Drawing.Size(930, 256);
            this.contact_grid.TabIndex = 2;
            this.contact_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contact_grid_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "ID";
            this.Column5.HeaderText = "شناسه";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "FirstName";
            this.Column1.HeaderText = "نام";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "نام خانوادگی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Gender";
            this.Column3.HeaderText = "جنسیت";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Birthdate";
            this.Column4.HeaderText = "تاریخ تولد";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("B Mitra", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manage_user_button,
            this.manage_contact_button,
            this.manage_phones_button,
            this.manage_pays_button,
            this.search_label,
            this.user_name_text,
            this.user_contacts_combo,
            this.confirm_admin_button});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manage_user_button
            // 
            this.manage_user_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insert_user_button,
            this.change_password_button});
            this.manage_user_button.Name = "manage_user_button";
            this.manage_user_button.Size = new System.Drawing.Size(93, 31);
            this.manage_user_button.Text = "مدیریت کاربر";
            // 
            // insert_user_button
            // 
            this.insert_user_button.Name = "insert_user_button";
            this.insert_user_button.Size = new System.Drawing.Size(154, 32);
            this.insert_user_button.Text = "افزودن کاربر";
            this.insert_user_button.Click += new System.EventHandler(this.insert_user_button_Click_1);
            // 
            // change_password_button
            // 
            this.change_password_button.Name = "change_password_button";
            this.change_password_button.Size = new System.Drawing.Size(154, 32);
            this.change_password_button.Text = "تغییر رمز عبور";
            this.change_password_button.Click += new System.EventHandler(this.change_password_button_Click);
            // 
            // manage_contact_button
            // 
            this.manage_contact_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insert_new_contact_button,
            this.update_contact_button,
            this.remove_contact_button});
            this.manage_contact_button.ForeColor = System.Drawing.Color.Black;
            this.manage_contact_button.Name = "manage_contact_button";
            this.manage_contact_button.Size = new System.Drawing.Size(109, 31);
            this.manage_contact_button.Text = "مدیریت مخاطب";
            // 
            // insert_new_contact_button
            // 
            this.insert_new_contact_button.Name = "insert_new_contact_button";
            this.insert_new_contact_button.Size = new System.Drawing.Size(195, 32);
            this.insert_new_contact_button.Text = "افزودن مخاطب جدید";
            this.insert_new_contact_button.Click += new System.EventHandler(this.insert_contact_button_Click);
            // 
            // update_contact_button
            // 
            this.update_contact_button.Name = "update_contact_button";
            this.update_contact_button.Size = new System.Drawing.Size(195, 32);
            this.update_contact_button.Text = "ویرایش مخاطب";
            this.update_contact_button.Click += new System.EventHandler(this.update_contact_button_Click);
            // 
            // remove_contact_button
            // 
            this.remove_contact_button.Name = "remove_contact_button";
            this.remove_contact_button.Size = new System.Drawing.Size(195, 32);
            this.remove_contact_button.Text = "حذف مخاطب";
            this.remove_contact_button.Click += new System.EventHandler(this.remove_contact_button_Click);
            // 
            // manage_phones_button
            // 
            this.manage_phones_button.Name = "manage_phones_button";
            this.manage_phones_button.Size = new System.Drawing.Size(177, 31);
            this.manage_phones_button.Text = "مدیریت شماره تماس و ایمیل";
            this.manage_phones_button.Click += new System.EventHandler(this.manage_phones_button_Click);
            // 
            // confirm_admin_button
            // 
            this.confirm_admin_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirm_contacts_button,
            this.confirm_transaction_button});
            this.confirm_admin_button.Name = "confirm_admin_button";
            this.confirm_admin_button.Size = new System.Drawing.Size(115, 31);
            this.confirm_admin_button.Text = "تأیید توسط ادمین";
            this.confirm_admin_button.Click += new System.EventHandler(this.confirm_contacts_button_Click);
            // 
            // user_name_text
            // 
            this.user_name_text.BackColor = System.Drawing.SystemColors.Info;
            this.user_name_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user_name_text.Name = "user_name_text";
            this.user_name_text.Size = new System.Drawing.Size(100, 31);
            this.user_name_text.Click += new System.EventHandler(this.user_name_text_Click);
            this.user_name_text.TextChanged += new System.EventHandler(this.user_name_text_TextChanged);
            // 
            // user_contacts_combo
            // 
            this.user_contacts_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_contacts_combo.Name = "user_contacts_combo";
            this.user_contacts_combo.Size = new System.Drawing.Size(121, 31);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contact_info);
            this.groupBox1.Controls.Add(this.search_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // contact_info
            // 
            this.contact_info.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contact_info.Enabled = false;
            this.contact_info.Location = new System.Drawing.Point(21, 44);
            this.contact_info.MaxLength = 50;
            this.contact_info.Name = "contact_info";
            this.contact_info.Size = new System.Drawing.Size(393, 37);
            this.contact_info.TabIndex = 8;
            this.contact_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contact_info.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(644, 44);
            this.search_tb.MaxLength = 50;
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(190, 37);
            this.search_tb.TabIndex = 8;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "جستجو:";
            // 
            // confirm_contacts_button
            // 
            this.confirm_contacts_button.Name = "confirm_contacts_button";
            this.confirm_contacts_button.Size = new System.Drawing.Size(220, 32);
            this.confirm_contacts_button.Text = "تأیید ایمیل و شماره تماس";
            this.confirm_contacts_button.Click += new System.EventHandler(this.confirm_contacts_button_Click_1);
            // 
            // confirm_transaction_button
            // 
            this.confirm_transaction_button.Name = "confirm_transaction_button";
            this.confirm_transaction_button.Size = new System.Drawing.Size(220, 32);
            this.confirm_transaction_button.Text = "تأیید دریافتی و پرداختی";
            this.confirm_transaction_button.Click += new System.EventHandler(this.confirm_transaction_button_Click);
            // 
            // search_label
            // 
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(65, 31);
            this.search_label.Text = "جستجو:";
            // 
            // manage_pays_button
            // 
            this.manage_pays_button.Name = "manage_pays_button";
            this.manage_pays_button.Size = new System.Drawing.Size(163, 31);
            this.manage_pays_button.Text = "مدیریت دریافتی و پرداختی";
            this.manage_pays_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manage_pays_button.Click += new System.EventHandler(this.manage_pays_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contact_grid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Mitra", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم اصلی";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contact_grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel welcome_label;
        private System.Windows.Forms.DataGridView contact_grid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem manage_phones_button;
        private System.Windows.Forms.ToolStripStatusLabel date_label;
        private System.Windows.Forms.ToolStripMenuItem manage_user_button;
        private System.Windows.Forms.ToolStripMenuItem insert_user_button;
        private System.Windows.Forms.ToolStripMenuItem change_password_button;
        private System.Windows.Forms.ToolStripMenuItem manage_contact_button;
        private System.Windows.Forms.ToolStripMenuItem insert_new_contact_button;
        private System.Windows.Forms.ToolStripMenuItem update_contact_button;
        private System.Windows.Forms.ToolStripMenuItem remove_contact_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox contact_info;
        private System.Windows.Forms.ToolStripMenuItem confirm_admin_button;
        private System.Windows.Forms.ToolStripTextBox user_name_text;
        private System.Windows.Forms.ToolStripComboBox user_contacts_combo;
        private System.Windows.Forms.ToolStripMenuItem confirm_contacts_button;
        private System.Windows.Forms.ToolStripMenuItem confirm_transaction_button;
        private System.Windows.Forms.ToolStripMenuItem search_label;
        private System.Windows.Forms.ToolStripMenuItem manage_pays_button;
    }
}