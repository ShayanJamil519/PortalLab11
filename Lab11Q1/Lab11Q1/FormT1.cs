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
    public partial class FormT1 : Form
    {
        public FormT1()
        {
            InitializeComponent();
        }

        private void FormT1_Load(object sender, EventArgs e)
        {
            dataGridViewTeachDet.ColumnCount = 3;
            dataGridViewTeachDet.Columns[0].Name = "ID";
            dataGridViewTeachDet.Columns[1].Name = "Name";
            dataGridViewTeachDet.Columns[2].Name = "Department Name";
            for(int i=0; i < 3; i++)
            {
                dataGridViewTeachDet.Columns[i].Width = 166;
            }

            string[] row = new string[] { "111222", "Asma", "Software"};
            dataGridViewTeachDet.Rows.Add(row);
            row = new string[] { "333444", "Simra", "Bcit"};
            dataGridViewTeachDet.Rows.Add(row);
            row = new string[] { "555666", "Farooq", "Civil" };
            dataGridViewTeachDet.Rows.Add(row);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormT2 ft2 = new FormT2();
            ft2.Show();
            this.Hide();
        }
    }
}
