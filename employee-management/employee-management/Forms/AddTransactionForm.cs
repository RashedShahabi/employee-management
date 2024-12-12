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
    public partial class AddTransactionForm : Form
    {
        private string _id;
        private string _header_info;
        public AddTransactionForm(string id, bool _open_for_confirm)
        {
            InitializeComponent();
            _id = id;

            var invisable = false;
            using (var db = new UnitOfWork())
            {
                var contact = db.ContactRepository.GetById(_id);
                Text += $" - [{contact.FirstName} {contact.LastName}]";
                _header_info = Text;

                invisable = _open_for_confirm;
            }

            pay_confirm_button.Visible = recive_confirm_button.Visible = invisable;
            groupBox1.Visible = groupBox2.Visible = !invisable;
        }

        private decimal GetTotalPaysAndShow()
        {
            decimal total = 0;

            using (var db = new UnitOfWork())
            {
                grid_pays.AutoGenerateColumns = false;

                var pays = db.ContactTransactionRepository
                    .Get(t => t.ContactID == _id && t.IsPayment)
                    .Select(t => new { ID = t.ID, Value = (int)t.Value, TransactionDate = DateConverter.ToHejriShamsi(t.TransactionDate), IsAccepted = t.IsAccepted ? "تأیید شده" : "تأیید نشده" })
                    .ToList();

                grid_pays.DataSource = pays;
                total = pays.Where(t => t.IsAccepted == "تأیید شده").Select(t => t.Value).Sum();
            }

            return total;

        }

        private decimal GetTotalRecivesAndShow()
        {
            decimal total = 0;

            using (var db = new UnitOfWork())
            {
                grid_recives.AutoGenerateColumns = false;

                var recives = db.ContactTransactionRepository
                    .Get(t => t.ContactID == _id && !t.IsPayment)
                    .Select(t => new { ID = t.ID, Value = (int)t.Value, TransactionDate = DateConverter.ToHejriShamsi(t.TransactionDate), IsAccepted = t.IsAccepted ? "تأیید شده" : "تأیید نشده" })
                    .ToList();

                grid_recives.DataSource = recives;
                total = recives.Where(t => t.IsAccepted == "تأیید شده").Select(t => t.Value).Sum();
            }

            return total;

        }

        public void ShowInfo()
        {
            var total_recives = GetTotalRecivesAndShow();
            var total_pays = GetTotalPaysAndShow();

            var final_value = total_recives - total_pays;

            if (final_value > 0) Text = $"{_header_info} _ بستانکار ({final_value})";
            if (final_value < 0) Text = $"{_header_info} _ بدهکار ({Math.Abs(final_value)})";
            if (final_value == 0) Text = _header_info;
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void add_pay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از افزودن پرداختی اطمینان دارید؟", "پرداختی", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                using (var db = new UnitOfWork())
                {
                    var payment = new ContactTransactions()
                    {
                        ID = TextGenerator.GetRandomString(),
                        ContactID = _id,
                        TransactionDate = DateTime.Now,
                        Value = pay_value.Value,
                        IsPayment = true,
                        IsAccepted = false
                    };

                    db.ContactTransactionRepository.Insert(payment);
                    db.Save();
                    pay_value.Value = pay_value.Minimum;
                    ShowInfo();
                }
            }
        }

        private void add_recive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از افزودن دریافتی اطمینان دارید؟", "دریافتی", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new UnitOfWork())
                {
                    var recive = new ContactTransactions()
                    {
                        ID = TextGenerator.GetRandomString(),
                        ContactID = _id,
                        TransactionDate = DateTime.Now,
                        Value = recive_value.Value,
                        IsPayment = false,
                        IsAccepted = false
                    };

                    db.ContactTransactionRepository.Insert(recive);
                    db.Save();
                    recive_value.Value = recive_value.Minimum;
                    ShowInfo();
                }
            }
        }

        private void pay_confirm_button_Click(object sender, EventArgs e)
        {
            if (grid_pays.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_pay_id = grid_pays.CurrentRow.Cells[0].Value.ToString();
                    var pay = db.ContactTransactionRepository.Get(p => p.ID == selected_pay_id).FirstOrDefault();
                    if (pay.IsAccepted)
                    {
                        MessageBox.Show("این پرداختی قبلا توسط ادمین تأیید شده است");
                    }
                    else
                    {
                        pay.IsAccepted = true;
                        db.ContactTransactionRepository.Update(pay);
                        db.Save();
                        MessageBox.Show($"پرداختی {selected_pay_id} توسط شما تأیید شد");
                        ShowInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک پرداختی برای تأیید نهایی انتخاب کنید");
            }
        }

        private void recive_confirm_button_Click(object sender, EventArgs e)
        {
            if (grid_recives.CurrentRow != null)
            {
                using (var db = new UnitOfWork())
                {
                    var selected_recive_id = grid_recives.CurrentRow.Cells[0].Value.ToString();
                    var recive = db.ContactTransactionRepository.Get(p => p.ID == selected_recive_id).FirstOrDefault();
                    if (recive.IsAccepted)
                    {
                        MessageBox.Show("این دریافتی قبلا توسط ادمین تأیید شده است");
                    }
                    else
                    {
                        recive.IsAccepted = true;
                        db.ContactTransactionRepository.Update(recive);
                        db.Save();
                        MessageBox.Show($"دریافتی {selected_recive_id} توسط شما تأیید شد");
                        ShowInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک دریافتی برای تأیید نهایی انتخاب کنید");
            }
        }
    }
}
