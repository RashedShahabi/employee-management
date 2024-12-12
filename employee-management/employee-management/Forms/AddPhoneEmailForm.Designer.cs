namespace ContactProject.Forms
{
    partial class AddPhoneEmailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_phone = new System.Windows.Forms.Button();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_email = new System.Windows.Forms.Button();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.remove_phone_button = new System.Windows.Forms.Button();
            this.phone_search_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_phones = new System.Windows.Forms.DataGridView();
            this.grid_emails = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.remove_email_button = new System.Windows.Forms.Button();
            this.search_email_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_confirm_button = new System.Windows.Forms.Button();
            this.email_confirm_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_phones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_emails)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_phone);
            this.groupBox1.Controls.Add(this.phone_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن شماره تماس";
            // 
            // add_phone
            // 
            this.add_phone.BackColor = System.Drawing.Color.PaleTurquoise;
            this.add_phone.Location = new System.Drawing.Point(17, 47);
            this.add_phone.Name = "add_phone";
            this.add_phone.Size = new System.Drawing.Size(91, 44);
            this.add_phone.TabIndex = 10;
            this.add_phone.Text = "ثبت";
            this.add_phone.UseVisualStyleBackColor = false;
            this.add_phone.Click += new System.EventHandler(this.add_phone_Click);
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(123, 52);
            this.phone_text.MaxLength = 11;
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(190, 37);
            this.phone_text.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "شماره تماس:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.add_email);
            this.groupBox2.Controls.Add(this.email_text);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(469, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "افزودن ایمیل";
            // 
            // add_email
            // 
            this.add_email.BackColor = System.Drawing.Color.PaleTurquoise;
            this.add_email.Location = new System.Drawing.Point(17, 47);
            this.add_email.Name = "add_email";
            this.add_email.Size = new System.Drawing.Size(91, 44);
            this.add_email.TabIndex = 10;
            this.add_email.Text = "ثبت";
            this.add_email.UseVisualStyleBackColor = false;
            this.add_email.Click += new System.EventHandler(this.add_email_Click);
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(123, 52);
            this.email_text.MaxLength = 50;
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(301, 37);
            this.email_text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "ایمیل:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.phone_confirm_button);
            this.groupBox3.Controls.Add(this.remove_phone_button);
            this.groupBox3.Controls.Add(this.phone_search_text);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.grid_phones);
            this.groupBox3.Location = new System.Drawing.Point(29, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 405);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست شماره های تماس";
            // 
            // remove_phone_button
            // 
            this.remove_phone_button.BackColor = System.Drawing.Color.Brown;
            this.remove_phone_button.Location = new System.Drawing.Point(17, 349);
            this.remove_phone_button.Name = "remove_phone_button";
            this.remove_phone_button.Size = new System.Drawing.Size(91, 44);
            this.remove_phone_button.TabIndex = 13;
            this.remove_phone_button.Text = "حذف";
            this.remove_phone_button.UseVisualStyleBackColor = false;
            this.remove_phone_button.Click += new System.EventHandler(this.remove_phone_button_Click);
            // 
            // phone_search_text
            // 
            this.phone_search_text.Location = new System.Drawing.Point(152, 42);
            this.phone_search_text.MaxLength = 11;
            this.phone_search_text.Name = "phone_search_text";
            this.phone_search_text.Size = new System.Drawing.Size(190, 37);
            this.phone_search_text.TabIndex = 11;
            this.phone_search_text.TextChanged += new System.EventHandler(this.phone_search_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "جستجو:";
            // 
            // grid_phones
            // 
            this.grid_phones.AllowUserToAddRows = false;
            this.grid_phones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_phones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_phones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_phones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_phones.DefaultCellStyle = dataGridViewCellStyle14;
            this.grid_phones.Location = new System.Drawing.Point(17, 99);
            this.grid_phones.Name = "grid_phones";
            this.grid_phones.ReadOnly = true;
            this.grid_phones.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.grid_phones.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.grid_phones.Size = new System.Drawing.Size(387, 244);
            this.grid_phones.TabIndex = 6;
            // 
            // grid_emails
            // 
            this.grid_emails.AllowUserToAddRows = false;
            this.grid_emails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_emails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid_emails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_emails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_emails.DefaultCellStyle = dataGridViewCellStyle17;
            this.grid_emails.Location = new System.Drawing.Point(28, 99);
            this.grid_emails.Name = "grid_emails";
            this.grid_emails.ReadOnly = true;
            this.grid_emails.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.grid_emails.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.grid_emails.Size = new System.Drawing.Size(447, 244);
            this.grid_emails.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.email_confirm_button);
            this.groupBox4.Controls.Add(this.remove_email_button);
            this.groupBox4.Controls.Add(this.grid_emails);
            this.groupBox4.Controls.Add(this.search_email_text);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(468, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 405);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "لیست ایمیل ها";
            // 
            // remove_email_button
            // 
            this.remove_email_button.BackColor = System.Drawing.Color.Brown;
            this.remove_email_button.Location = new System.Drawing.Point(28, 355);
            this.remove_email_button.Name = "remove_email_button";
            this.remove_email_button.Size = new System.Drawing.Size(91, 44);
            this.remove_email_button.TabIndex = 16;
            this.remove_email_button.Text = "حذف";
            this.remove_email_button.UseVisualStyleBackColor = false;
            this.remove_email_button.Click += new System.EventHandler(this.remove_email_button_Click);
            // 
            // search_email_text
            // 
            this.search_email_text.Location = new System.Drawing.Point(234, 42);
            this.search_email_text.MaxLength = 11;
            this.search_email_text.Name = "search_email_text";
            this.search_email_text.Size = new System.Drawing.Size(190, 37);
            this.search_email_text.TabIndex = 14;
            this.search_email_text.TextChanged += new System.EventHandler(this.search_email_text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "جستجو:";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "PhoneNumber";
            this.Column5.HeaderText = "شماره تماس";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IsAccepted";
            this.Column1.HeaderText = "وضعیت";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "ایمیل";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IsAccepted";
            this.Column2.HeaderText = "وضعیت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // phone_confirm_button
            // 
            this.phone_confirm_button.BackColor = System.Drawing.Color.Turquoise;
            this.phone_confirm_button.Location = new System.Drawing.Point(312, 349);
            this.phone_confirm_button.Name = "phone_confirm_button";
            this.phone_confirm_button.Size = new System.Drawing.Size(91, 44);
            this.phone_confirm_button.TabIndex = 13;
            this.phone_confirm_button.Text = "تأیید شدن";
            this.phone_confirm_button.UseVisualStyleBackColor = false;
            this.phone_confirm_button.Click += new System.EventHandler(this.phone_confirm_button_Click);
            // 
            // email_confirm_button
            // 
            this.email_confirm_button.BackColor = System.Drawing.Color.Turquoise;
            this.email_confirm_button.Location = new System.Drawing.Point(384, 349);
            this.email_confirm_button.Name = "email_confirm_button";
            this.email_confirm_button.Size = new System.Drawing.Size(91, 44);
            this.email_confirm_button.TabIndex = 13;
            this.email_confirm_button.Text = "تأیید شدن";
            this.email_confirm_button.UseVisualStyleBackColor = false;
            this.email_confirm_button.Click += new System.EventHandler(this.email_confirm_button_Click);
            // 
            // AddPhoneEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 572);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Mitra", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddPhoneEmailForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن شماره تماس و ایمیل";
            this.Load += new System.EventHandler(this.AddPhoneEmailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_phones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_emails)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_phone;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_email;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grid_phones;
        private System.Windows.Forms.DataGridView grid_emails;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button remove_phone_button;
        private System.Windows.Forms.TextBox phone_search_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remove_email_button;
        private System.Windows.Forms.TextBox search_email_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button phone_confirm_button;
        private System.Windows.Forms.Button email_confirm_button;
    }
}