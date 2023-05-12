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
    public partial class Form2 : Form
    {
        private bool isAdmin;
        public Form2(bool isAdmin)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                insertLabel.Hide();
                insertActiveSubst.Hide();
                insertActiveSubstInDrug.Hide();
                insertAssortiment.Hide();
                insertCategory.Hide();
                insertDevice.Hide();
                insertDrug.Hide();
                insertGood.Hide();
                insertPharmacist.Hide();
                insertPharmacy.Hide();
                insertPurchase.Hide();
                insertPurchases.Hide();
                insertView.Hide();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            return;
        }

        private void userChange_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Медикаменты":
                    break;
                case "Активные вещества в медикаментах":
                    break;
                case "Категории медикаментов":
                    break;
                case "ViewModel":
                    break;
                case "Активные вещества":
                    break;
                case "Покупки":
                    break;
                case "Приобретение одного товара":
                    break;
                case "Фармацевт":
                    break;
                case "Товары":
                    break;
                case "Медицинские приборы":
                    break;
                case "Наличие":
                    break;
                case "Аптеки":
                    break;
            }
        }

        private void insertDrug_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void insertActiveSubstInDrug_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void insertCategory_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void insertView_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void insertActiveSubst_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void insertPurchases_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }
    }
}
