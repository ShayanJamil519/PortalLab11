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
    public partial class FormT2 : Form
    {
        public FormT2()
        {
            InitializeComponent();
        }

        private void FormT2_Load(object sender, EventArgs e)
        {
            dataGridViewSearchTeach.ColumnCount = 2;
            dataGridViewSearchTeach.Columns[0].Name = "Course ID";
            dataGridViewSearchTeach.Columns[1].Name = "Course Name";
            for(int i =0; i < 2; i++)
            {
                dataGridViewSearchTeach.Columns[i].Width = 250;
            }

            string[] row = new string[] { "SE_201", "Object oriented programming" };
            dataGridViewSearchTeach.Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormT3 ft3 = new FormT3();
            ft3.Show();
            this.Hide();
        }
    }
}
