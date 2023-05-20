using DAL;
using Microsoft.Data.SqlClient;
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
            using (DbaptekiContext db = new DbaptekiContext())
            {
                Form3 form3 = new Form3();
                form3.dataGridView1.Columns.Clear();
                switch (comboBox1.Text)
                {
                    case "Медикаменты":
                        List<Drug> drugList;
                        drugList = db.Drugs.FromSqlRaw("SELECT * FROM Drugs").ToList();
                        form3.dataGridView1.DataSource = drugList;
                        form3.textBox1.Visible = true;
                        form3.button1.Visible = true;
                        form3.button1.Text = "Показать по производителю";
                        break;
                    case "Активные вещества в медикаментах":
                        List<ActiveSubstInDrug> activeSubstInDrugsList;
                        activeSubstInDrugsList = db.ActiveSubstInDrugs.FromSqlRaw("SELECT * FROM ActiveSubstInDrugs").ToList();
                        form3.dataGridView1.DataSource = activeSubstInDrugsList;
                        break;
                    case "Категории медикаментов":
                        List<CategoriesOfDrug> categoriesOfDrugList;
                        categoriesOfDrugList = db.CategoriesOfDrugs.FromSqlRaw("SELECT * FROM CategoriesOfDrugs").ToList();
                        form3.dataGridView1.DataSource = categoriesOfDrugList;
                        break;
                    case "ViewModel":
                        List<DrugsInfo> drugInfoList;
                        drugInfoList = db.DrugsInfos.FromSqlRaw("SELECT * FROM DrugsInfo").ToList();
                        form3.dataGridView1.DataSource = drugInfoList;
                        break;
                    case "Активные вещества":
                        List<ActiveSubstance> activeSubstList;
                        activeSubstList = db.ActiveSubstances.FromSqlRaw("SELECT * FROM ActiveSubstance").ToList();
                        form3.dataGridView1.DataSource = activeSubstList;
                        form3.textBox1.Visible = true;
                        form3.button1.Visible = true;
                        form3.button1.Text = "Показать по названию";
                        break;
                    case "Покупки":
                        List<Purchase1> purchasesList;
                        purchasesList = db.Purchases1.FromSqlRaw("SELECT * FROM Purchases").ToList();
                        form3.dataGridView1.DataSource = purchasesList;
                        break;
                    case "Приобретение одного товара":
                        List<Purchase> purchaseList;
                        purchaseList = db.Purchases.FromSqlRaw("SELECT * FROM Purchase").ToList();
                        form3.dataGridView1.DataSource = purchaseList;
                        break;
                    case "Фармацевт":
                        List<Pharmacist> pharmacistList;
                        pharmacistList = db.Pharmacists.FromSqlRaw("SELECT * FROM Pharmacists").ToList();
                        form3.dataGridView1.DataSource = pharmacistList;
                        form3.textBox1.Visible = true;
                        form3.button1.Visible = true;
                        form3.button1.Text = "Показать по фамилии";
                        break;
                    case "Товары":
                        List<Good> goodList;
                        goodList = db.Goods.FromSqlRaw("SELECT * FROM Goods").ToList();
                        form3.dataGridView1.DataSource = goodList;
                        break;
                    case "Медицинские приборы":
                        List<MedicalDevice> medicalDeviceList;
                        medicalDeviceList = db.MedicalDevices.FromSqlRaw("SELECT * FROM MedicalDevices").ToList();
                        form3.dataGridView1.DataSource = medicalDeviceList;
                        form3.textBox1.Visible = true;
                        form3.button1.Visible = true;
                        form3.button1.Text = "Показать по названию";
                        break;
                    case "Наличие":
                        List<Availability> availabilityList;
                        availabilityList = db.Availabilities.FromSqlRaw("SELECT * FROM Availability").ToList();
                        form3.dataGridView1.DataSource = availabilityList;
                        break;
                    case "Аптеки":
                        List<Pharmacy> pharmacyList;
                        pharmacyList = db.Pharmacies.FromSqlRaw("SELECT * FROM Pharmacies").ToList();
                        form3.dataGridView1.DataSource = pharmacyList;
                        break;
                }
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (form3.dataGridView1.Columns["Удаление"] == null)
                {
                    form3.dataGridView1.Columns.Add(uninstallButtonColumn);
                }
                form3.Show();
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

        private void insertPurchase_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void insertPharmacist_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void insertGood_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void insertDevice_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void insertAssortiment_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void insertPharmacy_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
        }//update delete search не по id
        //отчет, а-ля по дате продажи
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                using(DbaptekiContext db =new DbaptekiContext())
                {
                    SqlParameter param = new()
                    {
                        ParameterName = "@sales",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Direction = System.Data.ParameterDirection.Output,
                    };
                    var result = db.Database.ExecuteSqlRaw($"exec @sales = SalesForAllTime @PharmacyOGRN = {int.Parse(textBox1.Text)}", param);
                    MessageBox.Show(param.Value.ToString());
                };
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
        }
    }
}
