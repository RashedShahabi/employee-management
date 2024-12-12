namespace ContactProject.Forms
{
    partial class AddEditContactForm
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
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.first_name_text = new System.Windows.Forms.TextBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.last_name_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthdate_text = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gender_combobox
            // 
            this.gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Items.AddRange(new object[] {
            "مونث",
            "مذکر"});
            this.gender_combobox.Location = new System.Drawing.Point(454, 26);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(190, 37);
            this.gender_combobox.TabIndex = 10;
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.confirm_button.Location = new System.Drawing.Point(527, 145);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(117, 44);
            this.confirm_button.TabIndex = 9;
            this.confirm_button.Text = "ثبت نهایی";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "جنسیت:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "شناسه:";
            this.label1.Visible = false;
            // 
            // first_name_text
            // 
            this.first_name_text.Location = new System.Drawing.Point(145, 25);
            this.first_name_text.MaxLength = 50;
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(190, 37);
            this.first_name_text.TabIndex = 4;
            // 
            // id_text
            // 
            this.id_text.Enabled = false;
            this.id_text.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.id_text.Location = new System.Drawing.Point(145, 147);
            this.id_text.MaxLength = 10;
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(190, 32);
            this.id_text.TabIndex = 5;
            this.id_text.Visible = false;
            // 
            // last_name_text
            // 
            this.last_name_text.Location = new System.Drawing.Point(145, 82);
            this.last_name_text.MaxLength = 50;
            this.last_name_text.Name = "last_name_text";
            this.last_name_text.Size = new System.Drawing.Size(190, 37);
            this.last_name_text.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام خانوادگی:";
            // 
            // birthdate_text
            // 
            this.birthdate_text.Location = new System.Drawing.Point(454, 84);
            this.birthdate_text.Mask = "0000/00/00";
            this.birthdate_text.Name = "birthdate_text";
            this.birthdate_text.Size = new System.Drawing.Size(190, 37);
            this.birthdate_text.TabIndex = 11;
            this.birthdate_text.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "تاریخ تولد:";
            // 
            // AddEditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 209);
            this.Controls.Add(this.birthdate_text);
            this.Controls.Add(this.gender_combobox);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_name_text);
            this.Controls.Add(this.first_name_text);
            this.Controls.Add(this.id_text);
            this.Font = new System.Drawing.Font("B Mitra", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddEditContactForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مدیریت کاربر";
            this.Load += new System.EventHandler(this.AddEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gender_combobox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first_name_text;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox last_name_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox birthdate_text;
        private System.Windows.Forms.Label label5;
    }
}