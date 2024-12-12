using ContactProject_DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactProject
{
    public partial class ChangePasswordForm : Form
    {
        private User _user;
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            _user = user;
            show_password_button.Text = "مخفی کردن رمز عبور";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls.OfType<TextBox>())
            {
                if(string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("مقادیر موردنظر را تکمیل کنید");
                    return;
                }
            }

            if (new_password_text.Text != new_confirm_password_text.Text) 
            {
                MessageBox.Show("رمز عبور و تکرار رمز عبور یکسان نمیباشد");
                return;
            }
            if (new_password_text.Text.Length < 5 || new_password_text.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("رمز عبور شما باید متشکل از حروف و اعداد و بیشتر از 5 کارکتر باشد");
                return;
            }

            using (var db = new UnitOfWork())
            {
                var hashed_password = MD5Hash.MD5Hashing(prev_password_text.Text);

                var user = db.UserRepository.Get(u => 
                u.Username.Equals(_user.Username) && u.Password == hashed_password && u.RoleID == _user.RoleID)
                    .FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("رمز عبور شما صحیح نمیباشد");
                }
                else
                {
                    user.Password = MD5Hash.MD5Hashing(new_password_text.Text);
                    db.UserRepository.Update(user);
                    db.Save();
                }

                Application.Restart();

            }

        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(show_password_button.Checked)
            {
                show_password_button.Text = "نمایش رمز عبور";
                new_password_text.PasswordChar = new_confirm_password_text.PasswordChar = 
                    prev_password_text.PasswordChar = '*';

                new_password_text.UseSystemPasswordChar = new_confirm_password_text.UseSystemPasswordChar =
                    prev_password_text.UseSystemPasswordChar = true;
            }
            else
            {
                show_password_button.Text = "مخفی کردن رمز عبور";
                new_password_text.PasswordChar = new_confirm_password_text.PasswordChar =
                    prev_password_text.PasswordChar = '\0';

                new_password_text.UseSystemPasswordChar = new_confirm_password_text.UseSystemPasswordChar =
                    prev_password_text.UseSystemPasswordChar = false;
            }
        }
    }
}
