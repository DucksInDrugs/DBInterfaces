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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                List<Purchase1> purchasesList;
                purchasesList = db.Purchases1.FromSqlRaw("SELECT * FROM Purchases").ToList();
                var data = purchasesList.Where(purchase => purchase.PurchaseTime > dateTimePicker1.Value).Where(purchase => purchase.PurchaseTime < dateTimePicker2.Value).ToList();
                dataGridView1.DataSource = data;         
                dataGridView1.Columns.Remove("Pharmacists");
                dataGridView1.Columns.Remove("Purchases");
            }
        }
    }
}
