using ContactProject.Utils;
using ContactProject_DataLayer;
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
using System.Windows.Forms.VisualStyles;

namespace ContactProject.Forms
{
    public partial class MainForm : Form
    {
        private User _user;
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            var user_type = _user.RoleID == 0 ? "Admin" : "Normal User";
            welcome_label.Text = $"Welcome [{_user.Username}] as [{user_type}]";
            date_label.Text = $"\t{DateConverter.ToHejriShamsi(DateTime.Now)}";
            remove_contact_button.Visible = insert_user_button.Visible =
                confirm_admin_button.Visible = user_name_text.Visible =
                user_contacts_combo.Visible = search_label.Visible =
                user.RoleID == 0;
        }

        private void ShowContacts()
        {
            using (var db = new UnitOfWork())
            {
                var contact_list = new List<ContactViewModel>();

                if(search_tb.Text.Length == 0)
                {
                    foreach (var contact in db.ContactRepository.Get(c => c.OwnerUsername == _user.Username).ToList())
                    {
                        contact_list.Add(new ContactViewModel(contact));
                    }
                }
                else
                {
                    foreach (var contact in db.ContactRepository.Get(c => 
                                                c.OwnerUsername == _user.Username &&
                                                c.FirstName.Contains(search_tb.Text) ||
                                                c.LastName.Contains(search_tb.Text))
                                                .ToList())
                    {
                        contact_list.Add(new ContactViewModel(contact));
                    }
                }

                contact_grid.AutoGenerateColumns = false;
                contact_grid.DataSource = contact_list;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowContacts();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            ShowContacts();
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(_user).ShowDialog();
        }

        private void insert_user_button_Click(object sender, EventArgs e)
        {
            new LoginForm(true).ShowDialog();
        }

        private void insert_user_button_Click_1(object sender, EventArgs e)
        {
            new LoginForm(true).ShowDialog();
        }

        private void insert_contact_button_Click(object sender, EventArgs e)
        {
            new AddEditContactForm(_user.Username).ShowDialog();
            ShowContacts();
        }

        private void update_contact_button_Click(object sender, EventArgs e)
        {
            if(contact_grid.CurrentRow != null)
            {
                new AddEditContactForm(_user.Username, contact_grid.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
                ShowContacts();
            }
            else
            {
                MessageBox.Show("عنصری برای ویرایش انتخاب نشده است");
            }
            
        }

        private void manage_phones_button_Click(object sender, EventArgs e)
        {
            if (contact_grid.CurrentRow != null)
            {
                new AddPhoneEmailForm(contact_grid.CurrentRow.Cells[0].Value.ToString(), false).ShowDialog();
            }
            else
            {
                MessageBox.Show("عنصری برای درج شماره تماس یا ایمیل انتخاب نشده است");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void remove_contact_button_Click(object sender, EventArgs e)
        {
            if(contact_grid.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_contact_id = contact_grid.CurrentRow.Cells[0].Value.ToString();
                    var phones = db.ContactPhonesRepository.Get(c => c.ContactID == selected_contact_id).ToList();
                    var emails = db.ContactEmailsRepository.Get(c => c.ContactID == selected_contact_id).ToList();

                    var info = "آیا از حذف مخاطب انتخابی , اطمینان دارید؟ این مخاطب دارای لیستی از شماره تماس ها و ایمیل میباشد\n\n";

                    info += "لیست شماره های تماس:\n";

                    if (phones.Count == 0)
                    {
                        info += "فاقد شماره تماس\n";
                    }
                    else
                    {
                        foreach (var phone in phones)
                        {
                            info += (phone.PhoneNumber + "\n");
                        }
                    }

                    info += "\nلیست ایمیل ها:\n";
                    if(emails.Count == 0)
                    {
                        info += "فاقد ایمیل\n";
                    }
                    else
                    {
                        foreach (var email in emails)
                        {
                            info += (email.Email + "\n");
                        }
                    }

                    if (MessageBox.Show(info, "تأیید حذف مخاطب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        foreach (var phone in phones)
                        {
                            db.ContactPhonesRepository.Delete(phone);
                        }
                        foreach (var email in emails)
                        {
                            db.ContactEmailsRepository.Delete(email);
                        }

                        db.ContactRepository.Delete(selected_contact_id);
                        db.Save();
                        ShowContacts();
                    }
                }
            }
            else
            {
                MessageBox.Show("مخاطبی برای حذف کامل انتخاب کنید");

            }
        }

        private void contact_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contact_grid.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_contact_id = contact_grid.CurrentRow.Cells[0].Value.ToString();

                    var phones_count = db.ContactPhonesRepository.Get(c => c.ContactID == selected_contact_id).ToList().Count;
                    var emails_count = db.ContactEmailsRepository.Get(c => c.ContactID == selected_contact_id).ToList().Count;

                    var phone_count_text = phones_count == 0 ? "فاقد شماره تماس" : $"شامل {phones_count} شماره تماس";
                    var email_count_text = emails_count == 0 ? "فاقد ایمیل" : $"{emails_count} ایمیل";

                    contact_info.Text = $"{phone_count_text} و {email_count_text}";
                }
            }
        }

        private void confirm_contacts_button_Click(object sender, EventArgs e)
        {
            
        }

        private void user_name_text_TextChanged(object sender, EventArgs e)
        {
            user_contacts_combo.Items.Clear();
            using (var db = new UnitOfWork())
            {
                var user = db.UserRepository.Get(u => u.Username == user_name_text.Text).FirstOrDefault();
                if (user != null)
                {
                    user_contacts_combo.Items.AddRange(user.Contact.Select(c => $"{c.ID}_[{c.FirstName} {c.LastName}]").ToArray());
                    user_contacts_combo.SelectedIndex = 0;
                }
            }
        }

        private void user_name_text_Click(object sender, EventArgs e)
        {

        }

        private void confirm_transaction_button_Click(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var user = db.UserRepository.Get(u => u.Username == user_name_text.Text).FirstOrDefault();
                if (user != null)
                {
                    new AddTransactionForm(user_contacts_combo.Text.Split('_')[0], true).ShowDialog();
                }
                else
                {
                    MessageBox.Show("عنصری برای تأیید دریافتی و پرداختی یافت نشده است");
                }
            }
        }

        private void confirm_contacts_button_Click_1(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var user = db.UserRepository.Get(u => u.Username == user_name_text.Text).FirstOrDefault();
                if (user != null)
                {
                    new AddPhoneEmailForm(user_contacts_combo.Text.Split('_')[0], true).ShowDialog();
                }
                else
                {
                    MessageBox.Show("عنصری برای تأیید شماره تماس یا ایمیل یافت نشده است");
                }
            }
        }

        private void manage_pays_button_Click(object sender, EventArgs e)
        {
            if (contact_grid.CurrentRow != null)
            {
                new AddTransactionForm(contact_grid.CurrentRow.Cells[0].Value.ToString(), false).ShowDialog();
            }
            else
            {
                MessageBox.Show("عنصری برای درج دریافتی یا پرداختی انتخاب نشده است");
            }
        }
    }
}
