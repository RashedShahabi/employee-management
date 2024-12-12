namespace ContactProject
{
    partial class LoginForm
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
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.access_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(128, 33);
            this.username_text.MaxLength = 50;
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(190, 37);
            this.username_text.TabIndex = 0;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(128, 86);
            this.password_text.MaxLength = 50;
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(190, 37);
            this.password_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "رمز عبور:";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.login_button.Location = new System.Drawing.Point(352, 31);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(117, 44);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "ورود";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(352, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // access_combobox
            // 
            this.access_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.access_combobox.FormattingEnabled = true;
            this.access_combobox.Items.AddRange(new object[] {
            "ادمین",
            "کاربر"});
            this.access_combobox.Location = new System.Drawing.Point(128, 141);
            this.access_combobox.Name = "access_combobox";
            this.access_combobox.Size = new System.Drawing.Size(190, 37);
            this.access_combobox.TabIndex = 3;
            this.access_combobox.SelectedIndexChanged += new System.EventHandler(this.access_combobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "سطح دسترسی:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 207);
            this.Controls.Add(this.access_combobox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Font = new System.Drawing.Font("B Mitra", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ورود";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox access_combobox;
        private System.Windows.Forms.Label label3;
    }
}

