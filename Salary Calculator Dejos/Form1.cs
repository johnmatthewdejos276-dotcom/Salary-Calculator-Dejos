using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator_Dejos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSalary.Enabled = false;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1, value2;

            double.TryParse(txtHours.Text, out value1);
            double.TryParse(txtRate.Text, out value2);

            txtSalary.Text = (value1 * value2*24).ToString("F2");  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Clear();
            txtRate.Clear();
            txtSalary.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
