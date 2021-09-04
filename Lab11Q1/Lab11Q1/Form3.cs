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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridViewSearchStd.ColumnCount = 2;
            dataGridViewSearchStd.Columns[0].Name = "Course ID";
            dataGridViewSearchStd.Columns[1].Name = "Course Name";
            dataGridViewSearchStd.Columns[0].Width = 250;
            dataGridViewSearchStd.Columns[1].Width = 250;

            string[] row = new string[] { "SE-201","Object Oriented Programming"};
            dataGridViewSearchStd.Rows.Add(row);
            row = new string[] { "SE-207", "Software Engineering" };
            dataGridViewSearchStd.Rows.Add(row);
            row = new string[] { "PH-122", "Applied Physics" };
            dataGridViewSearchStd.Rows.Add(row);
            row = new string[] { "HSK-1", "Chineese Language" };
            dataGridViewSearchStd.Rows.Add(row);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 ff4 = new Form4();
            ff4.Show();
            this.Hide();
        }
    }
}
