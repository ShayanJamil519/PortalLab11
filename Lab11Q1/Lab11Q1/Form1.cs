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
    public partial class Form1 : Form
    {
        //Form2 ff2 = new Form2();
        //Form1 ff1 = new Form1();

        public Form1()
        {
            InitializeComponent();
        }

              
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStd_Click(object sender, EventArgs e)
        {
            Form2 ff2 = new Form2();
            ff2.Show();
            this.Hide();
        }

        private void buttonTeach_Click(object sender, EventArgs e)
        {
            FormT1 ft1 = new FormT1();
            ft1.Show();
            this.Hide();
        }
    }
}
