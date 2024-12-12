using ContactProject_DataLayer;
using ContactProject_DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactProject.Forms
{
    public partial class AddPhoneEmailForm : Form
    {
        private string _id;

        public AddPhoneEmailForm(string id, bool _open_for_confirm)
        {
            InitializeComponent();
            _id = id;

            var invisable = false;
            using (var db = new UnitOfWork())
            {
                var contact = db.ContactRepository.GetById(_id);
                Text += $" - [{contact.FirstName} {contact.LastName}]";

                invisable = _open_for_confirm;
            }

            email_confirm_button.Visible = phone_confirm_button.Visible = invisable;
            groupBox1.Visible = groupBox2.Visible = !invisable;
            remove_email_button.Visible = remove_phone_button.Visible = !invisable;

        }

        private void ShowPhones()
        {
            using (var db = new UnitOfWork())
            {
                grid_phones.AutoGenerateColumns = false;

                if (phone_search_text.Text.Length == 0)
                {
                    grid_phones.DataSource = db.ContactPhonesRepository
                    .Get(e => e.ContactID == _id)
                    .Select(u => new { PhoneNumber = u.PhoneNumber, IsAccepted = u.IsAccepted ? "تأیید شده" : "تأیید نشده" })
                    .ToList();
                }
                else
                {
                    grid_phones.DataSource = db.ContactPhonesRepository
                        .Get(phone => phone.ContactID == _id && phone.PhoneNumber.ToLower().Contains(phone_search_text.Text.ToLower()))
                        .Select(u => new { PhoneNumber = u.PhoneNumber, IsAccepted = u.IsAccepted ? "تأیید شده" : "تأیید نشده"})
                        .ToList();
                }

                
            }
        }

        private void ShowEmails()
        {
            using (var db = new UnitOfWork())
            {
                grid_emails.AutoGenerateColumns = false;

                if (search_email_text.Text.Length == 0)
                {
                    grid_emails.DataSource = db.ContactEmailsRepository
                        .Get(e => e.ContactID == _id)
                        .Select(u => new { Email = u.Email, IsAccepted = u.IsAccepted ? "تأیید شده" : "تأیید نشده" })
                        .ToList();
                }
                else
                {
                    grid_emails.DataSource = db.ContactEmailsRepository
                        .Get(email => email.ContactID == _id && email.Email.ToLower().Contains(search_email_text.Text.ToLower()))
                        .Select(u => new { Email = u.Email, IsAccepted = u.IsAccepted ? "تأیید شده" : "تأیید نشده" })
                        .ToList();
                }

            }
        }

        public void ShowInfo()
        {
            ShowPhones();
            ShowEmails();
        }
        private void AddPhoneEmailForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
                return false;

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void add_email_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_text.Text))
            {
                MessageBox.Show("مقدار ایمیل را وارد کنید");
            }
            else if(!IsValidEmail(email_text.Text))
            {
                MessageBox.Show("ایمیل صحیحی را وارد کنید");
            }
            else
            {
                using (var db = new UnitOfWork())
                {
                    var email = new ContactEmails()
                    {
                        ID = new Random().Next(),
                        ContactID = _id,
                        Email = email_text.Text,
                        IsAccepted = false
                    };

                    if (db.ContactEmailsRepository.Get(p => p.Email == email_text.Text && p.ContactID == _id).Any())
                    {
                        MessageBox.Show("این ایمیل برای شما قبلا ثبت شده است");
                    }
                    else
                    {
                        db.ContactEmailsRepository.Insert(email);
                        db.Save();
                        email_text.Text = string.Empty;
                        ShowInfo();
                    }

                }
            }
                
        }

        private void add_phone_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(phone_text.Text))
            {
                MessageBox.Show("مقدار شماره تماس را وارد کنید");
            }
            else if (phone_text.Text.Length < 11)
            {
                MessageBox.Show("شماره تماس باید 11 رقمی باشد");
            }
            else
            {
                using (var db = new UnitOfWork())
                {
                    var phone = new ContactPhones()
                    {
                        ID = new Random().Next(),
                        ContactID = _id,
                        PhoneNumber = phone_text.Text,
                        IsAccepted = false
                    };

                    if(db.ContactPhonesRepository.Get(p => p.PhoneNumber == phone_text.Text && p.ContactID == _id).Any())
                    {
                        MessageBox.Show("این شماره برای شما قبلا ثبت شده است");
                    }
                    else
                    {
                        db.ContactPhonesRepository.Insert(phone);
                        db.Save();
                        phone_text.Text = string.Empty;
                        ShowInfo();
                    }

                }
                
            }

        }

        private void remove_phone_button_Click(object sender, EventArgs e)
        {
            if (grid_phones.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_phone_number = grid_phones.CurrentRow.Cells[0].Value.ToString();
                    var phone = db.ContactPhonesRepository.Get(p => p.ContactID == _id && p.PhoneNumber == selected_phone_number).FirstOrDefault();
                    db.ContactPhonesRepository.Delete(phone);
                    db.Save();
                    MessageBox.Show($"شماره تماس {selected_phone_number} از لیست شماره های شما حذف شد");
                    phone_search_text.Text = phone_text.Text = string.Empty;
                    ShowPhones();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شماره تماس برای حذف شدن انتخاب کنید");
            }
        }

        private void remove_email_button_Click(object sender, EventArgs e)
        {
            if (grid_emails.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_email = grid_emails.CurrentRow.Cells[0].Value.ToString();
                    var email = db.ContactEmailsRepository.Get(p => p.ContactID == _id && p.Email == selected_email).FirstOrDefault();
                    db.ContactEmailsRepository.Delete(email);
                    db.Save();
                    MessageBox.Show($"ایمیل {selected_email} از لیست ایمیل های شما حذف شد");
                    search_email_text.Text = email_text.Text = string.Empty;
                    ShowEmails();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک ایمیل برای حذف شدن انتخاب کنید");
            }
        }

        private void phone_search_text_TextChanged(object sender, EventArgs e)
        {
            ShowPhones();
        }

        private void search_email_text_TextChanged(object sender, EventArgs e)
        {
            ShowEmails();
        }

        private void phone_confirm_button_Click(object sender, EventArgs e)
        {
            if (grid_phones.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_phone_number = grid_phones.CurrentRow.Cells[0].Value.ToString();
                    var phone = db.ContactPhonesRepository.Get(p => p.ContactID == _id && p.PhoneNumber == selected_phone_number).FirstOrDefault();
                    if (phone.IsAccepted) 
                    {
                        MessageBox.Show("این شماره تماس قبلا توسط ادمین تأیید شده است");
                    }
                    else
                    {
                        phone.IsAccepted = true;
                        db.ContactPhonesRepository.Update(phone);
                        db.Save();
                        MessageBox.Show($"شماره تماس {selected_phone_number} توسط شما تأیید شد");
                        phone_search_text.Text = phone_text.Text = string.Empty;
                        ShowPhones();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شماره تماس برای تأیید نهایی انتخاب کنید");
            }
        }

        private void email_confirm_button_Click(object sender, EventArgs e)
        {
            if (grid_emails.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_email = grid_emails.CurrentRow.Cells[0].Value.ToString();
                    var email = db.ContactEmailsRepository.Get(p => p.ContactID == _id && p.Email == selected_email).FirstOrDefault();
                    if (email.IsAccepted)
                    {
                        MessageBox.Show("این ایمیل قبلا توسط ادمین تأیید شده است");
                    }
                    else
                    {
                        email.IsAccepted = true;
                        db.ContactEmailsRepository.Update(email);
                        db.Save();
                        MessageBox.Show($"ایمیل {selected_email} توسط شما تأیید شد");
                        email_text.Text = phone_text.Text = string.Empty;
                        ShowEmails();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک ایمیل برای تأیید نهایی انتخاب کنید");
            }
        }
    }
}
