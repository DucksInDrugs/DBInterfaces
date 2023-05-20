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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBInterfaces
{
    public partial class Form17 : Form
    {
        private List<MedicalDevice> medicalDevices;
        private List<Good> goods;
        public Form17()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                textBox1.Text = goods.Where(good => good.AssortimentId == int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())).Select(good => good.Cost).First().ToString();
            }
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            using (DbaptekiContext db = new DbaptekiContext())
            {
                medicalDevices = db.MedicalDevices.FromSqlRaw("SELECT * FROM MedicalDevices").ToList();
                dataGridView1.DataSource = medicalDevices;
                goods = db.Goods.FromSqlRaw("SELECT * FROM Goods").ToList();
            }
        }
    }
}
