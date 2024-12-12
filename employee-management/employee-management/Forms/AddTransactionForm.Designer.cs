namespace ContactProject.Forms
{
    partial class AddTransactionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.recive_confirm_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_recive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pay_confirm_button = new System.Windows.Forms.Button();
            this.grid_pays = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_pay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pay_value = new System.Windows.Forms.NumericUpDown();
            this.recive_value = new System.Windows.Forms.NumericUpDown();
            this.grid_recives = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pays)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pay_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recive_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_recives)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.recive_confirm_button);
            this.groupBox4.Controls.Add(this.grid_recives);
            this.groupBox4.Location = new System.Drawing.Point(520, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 363);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "لیست دریافتی ها";
            // 
            // recive_confirm_button
            // 
            this.recive_confirm_button.BackColor = System.Drawing.Color.Turquoise;
            this.recive_confirm_button.Location = new System.Drawing.Point(360, 299);
            this.recive_confirm_button.Name = "recive_confirm_button";
            this.recive_confirm_button.Size = new System.Drawing.Size(91, 44);
            this.recive_confirm_button.TabIndex = 13;
            this.recive_confirm_button.Text = "تأیید شدن";
            this.recive_confirm_button.UseVisualStyleBackColor = false;
            this.recive_confirm_button.Click += new System.EventHandler(this.recive_confirm_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recive_value);
            this.groupBox2.Controls.Add(this.add_recive);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 88);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "افزودن دریافتی";
            // 
            // add_recive
            // 
            this.add_recive.BackColor = System.Drawing.Color.PaleTurquoise;
            this.add_recive.Location = new System.Drawing.Point(28, 30);
            this.add_recive.Name = "add_recive";
            this.add_recive.Size = new System.Drawing.Size(91, 44);
            this.add_recive.TabIndex = 10;
            this.add_recive.Text = "ثبت";
            this.add_recive.UseVisualStyleBackColor = false;
            this.add_recive.Click += new System.EventHandler(this.add_recive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "مقدار:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pay_confirm_button);
            this.groupBox3.Controls.Add(this.grid_pays);
            this.groupBox3.Location = new System.Drawing.Point(14, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 363);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست پرداختی ها";
            // 
            // pay_confirm_button
            // 
            this.pay_confirm_button.BackColor = System.Drawing.Color.Turquoise;
            this.pay_confirm_button.Location = new System.Drawing.Point(359, 299);
            this.pay_confirm_button.Name = "pay_confirm_button";
            this.pay_confirm_button.Size = new System.Drawing.Size(91, 44);
            this.pay_confirm_button.TabIndex = 13;
            this.pay_confirm_button.Text = "تأیید شدن";
            this.pay_confirm_button.UseVisualStyleBackColor = false;
            this.pay_confirm_button.Click += new System.EventHandler(this.pay_confirm_button_Click);
            // 
            // grid_pays
            // 
            this.grid_pays.AllowUserToAddRows = false;
            this.grid_pays.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_pays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column3,
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_pays.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_pays.Location = new System.Drawing.Point(27, 49);
            this.grid_pays.Name = "grid_pays";
            this.grid_pays.ReadOnly = true;
            this.grid_pays.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.grid_pays.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_pays.Size = new System.Drawing.Size(423, 244);
            this.grid_pays.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pay_value);
            this.groupBox1.Controls.Add(this.add_pay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 88);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن پرداختی";
            // 
            // add_pay
            // 
            this.add_pay.BackColor = System.Drawing.Color.PaleTurquoise;
            this.add_pay.Location = new System.Drawing.Point(27, 30);
            this.add_pay.Name = "add_pay";
            this.add_pay.Size = new System.Drawing.Size(91, 44);
            this.add_pay.TabIndex = 10;
            this.add_pay.Text = "ثبت";
            this.add_pay.UseVisualStyleBackColor = false;
            this.add_pay.Click += new System.EventHandler(this.add_pay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "مقدار:";
            // 
            // pay_value
            // 
            this.pay_value.Location = new System.Drawing.Point(248, 36);
            this.pay_value.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.pay_value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pay_value.Name = "pay_value";
            this.pay_value.Size = new System.Drawing.Size(165, 37);
            this.pay_value.TabIndex = 11;
            this.pay_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pay_value.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // recive_value
            // 
            this.recive_value.Location = new System.Drawing.Point(248, 34);
            this.recive_value.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.recive_value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.recive_value.Name = "recive_value";
            this.recive_value.Size = new System.Drawing.Size(165, 37);
            this.recive_value.TabIndex = 11;
            this.recive_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recive_value.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // grid_recives
            // 
            this.grid_recives.AllowUserToAddRows = false;
            this.grid_recives.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_recives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_recives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_recives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Mitra", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_recives.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_recives.Location = new System.Drawing.Point(28, 49);
            this.grid_recives.Name = "grid_recives";
            this.grid_recives.ReadOnly = true;
            this.grid_recives.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.grid_recives.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_recives.Size = new System.Drawing.Size(423, 244);
            this.grid_recives.TabIndex = 6;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID";
            this.Column4.HeaderText = "شناسه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Value";
            this.Column5.HeaderText = "میزان پرداختی";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TransactionDate";
            this.Column3.HeaderText = "تاریخ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IsAccepted";
            this.Column1.HeaderText = "وضعیت";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "شناسه";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn1.HeaderText = "میزان دریافتی";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TransactionDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsAccepted";
            this.dataGridViewTextBoxColumn4.HeaderText = "وضعیت";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 491);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Mitra", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "AddTransactionForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن تراکنش پرداختی و دریافتی";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pay_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recive_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_recives)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button recive_confirm_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown recive_value;
        private System.Windows.Forms.Button add_recive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button pay_confirm_button;
        private System.Windows.Forms.DataGridView grid_pays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown pay_value;
        private System.Windows.Forms.Button add_pay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_recives;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}