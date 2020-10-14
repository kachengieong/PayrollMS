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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //firstname
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //lastname
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //date of birth
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //female
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //male
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //employee department
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //employee position
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //yearly income choice disables hourly income
            textBox5.Enabled = radioButton3.Checked; 
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //hourly income choice disables gross income
            textBox6.Enabled = radioButton4.Checked;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // gross income
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // hourly income
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //date hired
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Health 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dental 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vision
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
