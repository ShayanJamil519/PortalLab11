using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11Q1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Address";
            dataGridView1.Columns[3].Name = "Department Name";
            dataGridView1.Columns[4].Name = "Program Name";
            
            string[] row = new string[] { "SE-20062","Shayan", "ABC", "Software", "OOP"};
            dataGridView1.Rows.Add(row);
            row = new string[] { "SE-20063", "Arshan","DEF", "Software", "SE" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "SE-20064","Abdullah", "ABC", "Software", "AP" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "SE-20065","Umer", "ABC", "Software", "Arw" };
            dataGridView1.Rows.Add(row);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ff3 = new Form3();
            ff3.Show();
            this.Hide();
        }
    }
}
