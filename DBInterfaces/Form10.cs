using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBInterfaces
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox12.Text))
            {
                e.Cancel = true;
                textBox12.Focus();
                errorProvider1.SetError(textBox12, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox12, null);
            }
        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox11.Text))
            {
                e.Cancel = true;
                textBox11.Focus();
                errorProvider1.SetError(textBox11, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox11, null);
            }
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                e.Cancel = true;
                textBox10.Focus();
                errorProvider1.SetError(textBox10, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox10, null);
            }
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                e.Cancel = true;
                textBox9.Focus();
                errorProvider1.SetError(textBox9, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox9, null);
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                e.Cancel = true;
                textBox8.Focus();
                errorProvider1.SetError(textBox8, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox8, null);
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                e.Cancel = true;
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox6, null);
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider1.SetError(textBox5, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox5, null);
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, null);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (DbaptekiContext db = new DbaptekiContext())
                {
                    if (string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox7.Text))
                    {
                        int count = db.Database.ExecuteSqlRaw("INSERT INTO Pharmacists (Diploma, Surname, Name, Salary, Passport, TIN, Telephone, Address, Insurance, OGRN) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", textBox1.Text, textBox11.Text, textBox9.Text, Double.Parse(textBox5.Text), textBox3.Text, int.Parse(textBox12.Text), textBox10.Text, textBox8.Text, textBox6.Text, int.Parse(textBox4.Text));
                    }
                    else if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        int count = db.Database.ExecuteSqlRaw("INSERT INTO Pharmacists (Diploma, Surname, Name, Patronymic, Salary, Passport, TIN, Telephone, Address, Insurance, OGRN) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", textBox1.Text, textBox11.Text, textBox9.Text, textBox7.Text, Double.Parse(textBox5.Text), textBox3.Text, int.Parse(textBox12.Text), textBox10.Text, textBox8.Text, textBox6.Text, int.Parse(textBox4.Text));
                    }
                    else if (string.IsNullOrEmpty(textBox7.Text))
                    {
                        int count = db.Database.ExecuteSqlRaw("INSERT INTO Pharmacists (Diploma, Surname, Name, Salary, Passport, TIN, Telephone, Address, Insurance, OGRN, BuyId) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", textBox1.Text, textBox11.Text, textBox9.Text, Double.Parse(textBox5.Text), textBox3.Text, int.Parse(textBox12.Text), textBox10.Text, textBox8.Text, textBox6.Text, int.Parse(textBox4.Text), int.Parse(textBox2.Text));
                    }
                    else
                    {
                        int count = db.Database.ExecuteSqlRaw("INSERT INTO Pharmacists VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", textBox1.Text, textBox11.Text, textBox9.Text, textBox7.Text, Double.Parse(textBox5.Text), textBox3.Text, int.Parse(textBox12.Text), textBox10.Text, textBox8.Text, textBox6.Text, int.Parse(textBox4.Text), int.Parse(textBox2.Text));
                    }

                }
                Close();
            }
        }
    }
}
