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
    public partial class Form3 : Form
    {
        string tableString;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void медикаментыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if(dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<Drug> drugList;
                drugList = db.Drugs.FromSqlRaw("SELECT * FROM Drugs").ToList();
                dataGridView1.DataSource = drugList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                    dataGridView1.CellClick += dataGridView1_CellClick_1;
                }
            }
            textBox1.Visible = true;
            button1.Visible = true;
            button1.Text = "Показать по производителю";
        }

        private void активныеВеществаВМедикаментахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<ActiveSubstInDrug> activeSubstInDrugsList;
                activeSubstInDrugsList = db.ActiveSubstInDrugs.FromSqlRaw("SELECT * FROM ActiveSubstInDrugs").ToList();
                dataGridView1.DataSource = activeSubstInDrugsList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void категорииМедикаментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<CategoriesOfDrug> categoriesOfDrugList;
                categoriesOfDrugList = db.CategoriesOfDrugs.FromSqlRaw("SELECT * FROM CategoriesOfDrugs").ToList();
                dataGridView1.DataSource = categoriesOfDrugList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void viewModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<DrugsInfo> drugInfoList;
                drugInfoList = db.DrugsInfos.FromSqlRaw("SELECT * FROM DrugsInfo").ToList();
                dataGridView1.DataSource = drugInfoList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void активныеВеществаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<ActiveSubstance> activeSubstList;
                activeSubstList = db.ActiveSubstances.FromSqlRaw("SELECT * FROM ActiveSubstance").ToList();
                dataGridView1.DataSource = activeSubstList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
            textBox1.Visible = true;
            button1.Visible = true;
            button1.Text = "Показать по названию";
        }

        private void покупкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<Purchase1> purchasesList;
                purchasesList = db.Purchases1.FromSqlRaw("SELECT * FROM Purchases").ToList();
                dataGridView1.DataSource = purchasesList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void приобретениеОдногоТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<Purchase> purchaseList;
                purchaseList = db.Purchases.FromSqlRaw("SELECT * FROM Purchase").ToList();
                dataGridView1.DataSource = purchaseList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void фармацевтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<Pharmacist> pharmacistList;
                pharmacistList = db.Pharmacists.FromSqlRaw("SELECT * FROM Pharmacists").ToList();
                dataGridView1.DataSource = pharmacistList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
            textBox1.Visible = true;
            button1.Visible = true;
            button1.Text = "Показать по фамилии";
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<Good> goodList;
                goodList = db.Goods.FromSqlRaw("SELECT * FROM Goods").ToList();
                dataGridView1.DataSource = goodList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void медицинскиеПриборыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<MedicalDevice> medicalDeviceList;
                medicalDeviceList = db.MedicalDevices.FromSqlRaw("SELECT * FROM MedicalDevices").ToList();
                dataGridView1.DataSource = medicalDeviceList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
            textBox1.Visible = true;
            button1.Visible = true;
            button1.Text = "Показать по названию";
        }

        private void наличиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<Availability> availabilityList;
                availabilityList = db.Availabilities.FromSqlRaw("SELECT * FROM Availability").ToList();
                dataGridView1.DataSource = availabilityList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void аптекиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Удаление"] != null)
                {
                    dataGridView1.Columns.Clear();
                }
                List<Pharmacy> pharmacyList;
                pharmacyList = db.Pharmacies.FromSqlRaw("SELECT * FROM Pharmacies").ToList();
                dataGridView1.DataSource = pharmacyList;
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Удаление";
                uninstallButtonColumn.Text = "Delete";
                uninstallButtonColumn.HeaderText = "Delete";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Удаление"] == null)
                {
                    dataGridView1.Columns.Add(uninstallButtonColumn);
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Удаление"].Index)
            {
                using (DbaptekiContext db = new DbaptekiContext())
                {
                    if (dataGridView1.Columns["Salary"] != null)
                    {
                        var data = (Pharmacist)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM Pharmacists WHERE PharmacistId = {data.PharmacistId}");
                    }
                    else if (dataGridView1.Columns["Direction"] != null)
                    {
                        var data = (Pharmacy)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM Pharmacies WHERE OGRN = {data.Ogrn}");
                    }
                    else if (dataGridView1.Columns["TotalCost"] != null)
                    {
                        var data = (Purchase1)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM Purchases WHERE DrugId = {data.BuysId}");
                    }
                    else if (dataGridView1.Columns["DeviceName"] != null)
                    {
                        var data = (MedicalDevice)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM MedicalDevices WHERE DeviceId = {data.DeviceId}");
                    }
                    else if (dataGridView1.Columns["Dosage"] != null)
                    {
                        var data = (ActiveSubstInDrug)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM ActiveSubstInDrugs WHERE SubstInDrugId = {data.SubstInDrugId}");
                    }
                    else if (dataGridView1.Columns["SubstanceName"] != null)
                    {
                        var data = (ActiveSubstance)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM ActiveSubstance WHERE SubstanceId = {data.SubstanceId}");
                    }
                    else if (dataGridView1.Columns["DrugsClassification"] != null)
                    {
                        var data = (CategoriesOfDrug)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM CategoriesOfDrugs WHERE CategoryId = {data.CategoryId}");
                    }
                    else if (dataGridView1.Columns["Manufacturer"] != null)
                    {
                        var data = (Drug)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM Drugs WHERE DrugId = {data.DrugId}");
                    }
                    else if (dataGridView1.Columns["Cost"] != null)
                    {
                        var data = (Good)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM Goods WHERE DrugId = {data.AssortimentId}");
                    }
                    else if (dataGridView1.Columns["Amount"] != null && dataGridView1.Columns["OGRN"] != null)
                    {
                        var data = (Availability)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM Availability WHERE AssortimentId = {data.AssortimentId} and OGRN = {data.Ogrn}");
                    }
                    else if (dataGridView1.Columns["Amount"] != null && dataGridView1.Columns["GoodId"] != null)
                    {
                        var data = (Purchase)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                        db.Database.ExecuteSql($"DELETE FROM Purchase WHERE PurchaseId = {data.PurchaseId}");
                    }
                    dataGridView1.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns["Salary"] != null)
            {
                using (DbaptekiContext db = new DbaptekiContext())
                {
                    List<Pharmacist> pharmacistList;
                    pharmacistList = db.Pharmacists.FromSqlRaw("SELECT * FROM Pharmacists").ToList();
                    var data = pharmacistList.Where(ph => ph.Surname.Contains(textBox1.Text)).ToList();
                    dataGridView1.DataSource = data;
                }
            }
            else if (dataGridView1.Columns["DeviceName"] != null)
            {
                using (DbaptekiContext db = new DbaptekiContext())
                {
                    List<MedicalDevice> medicalDeviceList;
                    medicalDeviceList = db.MedicalDevices.FromSqlRaw("SELECT * FROM MedicalDevices").ToList();
                    var data = medicalDeviceList.Where(device => device.DeviceName.Contains(textBox1.Text)).ToList();
                    dataGridView1.DataSource = data;
                }
            }
            else if (dataGridView1.Columns["SubstanceName"] != null)
            {
                using (DbaptekiContext db = new DbaptekiContext())
                {
                    List<ActiveSubstance> activeSubstList;
                    activeSubstList = db.ActiveSubstances.FromSqlRaw("SELECT * FROM ActiveSubstance").ToList();
                    var data = activeSubstList.Where(subst => subst.SubstanceName.Contains(textBox1.Text)).ToList();
                    dataGridView1.DataSource = data;
                }
            }
            else if (dataGridView1.Columns["Manufacturer"] != null)
            {
                using (DbaptekiContext db = new DbaptekiContext())
                {
                    List<Drug> drugList;
                    drugList = db.Drugs.FromSqlRaw("SELECT * FROM Drugs").ToList();
                    var data = drugList.Where(drug => drug.Manufacturer.Contains(textBox1.Text)).ToList();
                    dataGridView1.DataSource = data;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                if (dataGridView1.Columns["Salary"] != null)
                {
                    var data = (Pharmacist)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE Pharmacists SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE PharmacistId = {data.PharmacistId}");
                }
                else if (dataGridView1.Columns["Direction"] != null)
                {
                    var data = (Pharmacy)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE Pharmacies SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE OGRN = {data.Ogrn}");
                }
                else if (dataGridView1.Columns["TotalCost"] != null)
                {
                    var data = (Purchase1)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE Purchases SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE DrugId = {data.BuysId}");
                }
                else if (dataGridView1.Columns["DeviceName"] != null)
                {
                    var data = (MedicalDevice)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE MedicalDevices SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE DeviceId = {data.DeviceId}");
                }
                else if (dataGridView1.Columns["Dosage"] != null)
                {
                    var data = (ActiveSubstInDrug)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE ActiveSubstInDrugs SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE SubstInDrugId = {data.SubstInDrugId}");
                }
                else if (dataGridView1.Columns["SubstanceName"] != null)
                {
                    var data = (ActiveSubstance)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE ActiveSubstance SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE SubstanceId = {data.SubstanceId}");
                }
                else if (dataGridView1.Columns["DrugsClassification"] != null)
                {
                    var data = (CategoriesOfDrug)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE CategoriesOfDrugs SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE CategoryId = {data.CategoryId}");
                }
                else if (dataGridView1.Columns["Manufacturer"] != null)
                {
                    var data = (Drug)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE Drugs SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE DrugId = {data.DrugId}");
                }
                else if (dataGridView1.Columns["Cost"] != null)
                {
                    var data = (Good)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE Goods SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE DrugId = {data.AssortimentId}");
                }
                else if (dataGridView1.Columns["Amount"] != null && dataGridView1.Columns["OGRN"] != null)
                {
                    var data = (Availability)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE Availability SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE AssortimentId = {data.AssortimentId} and OGRN = {data.Ogrn}");
                }
                else if (dataGridView1.Columns["Amount"] != null && dataGridView1.Columns["GoodId"] != null)
                {
                    var data = (Purchase)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    db.Database.ExecuteSqlRaw($"UPDATE Purchase SET {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' WHERE WHERE PurchaseId = {data.PurchaseId}");
                }
                dataGridView1.Refresh();
            }
        }
    }
}