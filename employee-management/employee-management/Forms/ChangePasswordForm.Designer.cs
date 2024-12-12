namespace ContactProject
{
    partial class ChangePasswordForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.new_password_text = new System.Windows.Forms.TextBox();
            this.prev_password_text = new System.Windows.Forms.TextBox();
            this.new_confirm_password_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.show_password_button = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(228, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "اعمال";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "رمز عبور جدید:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "رمز عبور قبلی:";
            // 
            // new_password_text
            // 
            this.new_password_text.Location = new System.Drawing.Point(155, 81);
            this.new_password_text.MaxLength = 50;
            this.new_password_text.Name = "new_password_text";
            this.new_password_text.Size = new System.Drawing.Size(190, 37);
            this.new_password_text.TabIndex = 3;
            // 
            // prev_password_text
            // 
            this.prev_password_text.Location = new System.Drawing.Point(155, 28);
            this.prev_password_text.MaxLength = 50;
            this.prev_password_text.Name = "prev_password_text";
            this.prev_password_text.Size = new System.Drawing.Size(190, 37);
            this.prev_password_text.TabIndex = 4;
            // 
            // new_confirm_password_text
            // 
            this.new_confirm_password_text.Location = new System.Drawing.Point(155, 137);
            this.new_confirm_password_text.MaxLength = 50;
            this.new_confirm_password_text.Name = "new_confirm_password_text";
            this.new_confirm_password_text.Size = new System.Drawing.Size(190, 37);
            this.new_confirm_password_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "تکرار رمز عبور جدید:";
            // 
            // show_password_button
            // 
            this.show_password_button.Appearance = System.Windows.Forms.Appearance.Button;
            this.show_password_button.AutoSize = true;
            this.show_password_button.Location = new System.Drawing.Point(30, 199);
            this.show_password_button.Name = "show_password_button";
            this.show_password_button.Size = new System.Drawing.Size(119, 40);
            this.show_password_button.TabIndex = 8;
            this.show_password_button.Text = "نمایش رمز عبور";
            this.show_password_button.UseVisualStyleBackColor = true;
            this.show_password_button.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 268);
            this.Controls.Add(this.show_password_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_confirm_password_text);
            this.Controls.Add(this.new_password_text);
            this.Controls.Add(this.prev_password_text);
            this.Font = new System.Drawing.Font("B Mitra", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر رمز عبور";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_password_text;
        private System.Windows.Forms.TextBox prev_password_text;
        private System.Windows.Forms.TextBox new_confirm_password_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox show_password_button;
    }
}