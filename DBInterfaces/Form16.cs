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
    public partial class Form16 : Form
    {
        private List<Pharmacy> pharmacies;
        private List<Availability> availabilities;
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                pharmacies = db.Pharmacies.FromSqlRaw("SELECT * FROM Pharmacies").ToList();
                foreach (var ph in pharmacies)
                {
                    comboBox1.Items.Add(ph.Ogrn);
                }
                availabilities = db.Availabilities.FromSqlRaw("SELECT * FROM Availability").ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pharm = pharmacies.Where(ph => ph.Ogrn == int.Parse(comboBox1.Text)).ToList();
            dataGridView2.Visible = true;
            dataGridView2.DataSource = pharm;
            dataGridView2.Columns.RemoveAt(0);
            dataGridView2.Columns.Remove("Availabilities");
            dataGridView2.Columns.Remove("Pharmacists");
            var availableAssortiment = availabilities.Where(av => av.Ogrn == int.Parse(comboBox1.Text)).ToList();
            dataGridView1.DataSource = availableAssortiment;
            dataGridView1.Visible = true;
            dataGridView1.Columns.RemoveAt(3);
            dataGridView1.Columns.RemoveAt(3);
            
        }
    }
}
