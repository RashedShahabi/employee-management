using ContactProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactProject_DataLayer.Contract;
using ContactProject_DataLayer.DataModel;
using ContactProject.Forms;

namespace ContactProject
{
    public partial class LoginForm : Form
    {
        private bool _for_insert;
        public LoginForm(bool for_insert)
        {
            InitializeComponent();
            access_combobox.SelectedIndex = 0;
            _for_insert = for_insert;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            access_combobox_SelectedIndexChanged(null, null);
        }

        private void access_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = _for_insert ? "ثبت" : "ورود";
            Text = _for_insert ? "فرم ثبت کاربر" : "فرم ورود";
            login_button.Text = $"{type} {access_combobox.SelectedItem}";
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_text.Text) || string.IsNullOrEmpty(password_text.Text))
            {
                MessageBox.Show("مقادیر ورودی را وارد کنید");
            }
            else
            {
                using (var db = new UnitOfWork())
                {
                    var hashed_password = MD5Hash.MD5Hashing(password_text.Text);

                    if (_for_insert)
                    {
                        if(db.UserRepository.GetById(username_text.Text) == null)
                        {
                            var user = new User()
                            {
                                Username = username_text.Text,
                                Password = hashed_password,
                                RoleID = access_combobox.SelectedIndex,
                            };
                            db.UserRepository.Insert(user);
                            db.Save();
                            MessageBox.Show("کاربر موردنظر در سامانه درج شد");
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری دیگری انتخاب کنید");
                        }
                    }
                    else
                    {
                        var user = db.UserRepository.Get(u =>
                            u.Username.Equals(username_text.Text) &&
                            u.Password == hashed_password &&
                            u.RoleID == access_combobox.SelectedIndex)
                            .FirstOrDefault();

                        if (user == null)
                        {
                            MessageBox.Show("نام کاربری و رمز عبور صحیح نمیباشد");
                        }
                        else
                        {
                            Opacity = 0.001;
                            new MainForm(user).ShowDialog();
                            password_text.Text = "";
                            Application.Exit();
                        }
                    }
                    
                }

            }

        }
    }
}
