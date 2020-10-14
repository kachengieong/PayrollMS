using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGoC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Position View 
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Enter EmpID
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Enter Password
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimize the window when clicked

            Form2 HR = new Form2(); 
            HR.Show();
        }
    }
}
