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
    public partial class Form15 : Form
    {
        private List<Pharmacy> pharmacies;
        private List<Pharmacist> pharmacists;
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                pharmacies = db.Pharmacies.FromSqlRaw("SELECT * FROM Pharmacies").ToList();
                foreach (var ph in pharmacies)
                {
                    comboBox1.Items.Add(ph.Ogrn);
                }
                pharmacists = db.Pharmacists.FromSqlRaw("SELECT * FROM Pharmacists").ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            var info = pharmacies.Where(ph => ph.Ogrn == int.Parse(comboBox1.Text)).ToList();
            dataGridView2.DataSource = info;
            dataGridView2.Columns.RemoveAt(0);
            dataGridView2.Columns.Remove("Availabilities");
            dataGridView2.Columns.Remove("Pharmacists");
            var guys = pharmacists.Where(ph => ph.Ogrn == int.Parse(comboBox1.Text)).ToList();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = guys;
            dataGridView1.Columns.RemoveAt(13);
            dataGridView1.Columns.RemoveAt(13);
        }
    }
}
