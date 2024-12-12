using ContactProject.Utils;
using ContactProject_DataLayer.DataModel;
using ContactProject_DataLayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactProject.Forms
{
    public partial class AddEditContactForm : Form
    {
        private string _contact_id;
        private string _owner_username;
        public AddEditContactForm(string owner_username, string contact_id = "")
        {
            InitializeComponent();
            _contact_id = contact_id.Trim();
            _owner_username = owner_username;
            gender_combobox.SelectedIndex = 0;
            id_text.Enabled = false;
        }

        private void AddEditUser_Load(object sender, EventArgs e)
        {
            if(_contact_id != "")
            {
                confirm_button.Text = "ویرایش نهایی";
                id_text.Text = _contact_id;

                using (var db = new UnitOfWork())
                {
                    var contact = db.ContactRepository.GetById(_contact_id);

                    first_name_text.Text = contact.FirstName;
                    last_name_text.Text = contact.LastName;
                    gender_combobox.SelectedIndex = Convert.ToInt32(contact.Gender);
                    birthdate_text.Text = DateConverter.ToHejriShamsi(contact.Birthdate).Replace("/", "");
                }
            }
            else
            {
                id_text.Text = TextGenerator.GetRandomString();
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("مقادیر موردنظر را تکمیل کنید");
                    return;
                }
            }

            if(!birthdate_text.MaskFull)
            {
                MessageBox.Show("تاریخ تولد را تکمیل کنید");
                return;
            }

            using (var db = new UnitOfWork())
            {
                var contact = new Contact()
                {
                    ID = id_text.Text,
                    FirstName = first_name_text.Text,
                    LastName = last_name_text.Text,
                    Gender = Convert.ToBoolean(gender_combobox.SelectedIndex),
                    Birthdate = DateConverter.ToMiladi(birthdate_text.Text),
                    OwnerUsername = _owner_username
                };

                if (_contact_id == "")
                {
                    while (db.ContactRepository.GetById(contact.ID) != null)
                    {
                        contact.ID = TextGenerator.GetRandomString();
                    }

                    db.ContactRepository.Insert(contact);

                }
                else
                {
                    db.ContactRepository.Update(contact);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
