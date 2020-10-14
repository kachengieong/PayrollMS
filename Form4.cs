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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search Emp ID then retrieve Info for labels and textboxes (error handling employee number search !!!)

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Save New Info to database 


            string message = "Confirm Updating Employee Record";
            string title = "Update Record";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // Update Record



                this.Close();
                MessageBox.Show("Empolyee Record Updated");
            }
            else
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // DELETE EMP RECORD 
            string message = "Confirm Deleting Employee Record";
            string title = "Delete Record";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // Delete Record



                this.Close();
                MessageBox.Show("Empolyee Record Deleted");
            }
            else
            {
                this.Close();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if filled up change database
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if filled up!!! change database 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = radioButton3.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = radioButton4.Checked;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //updated gross income
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //updated hourly income
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change health benefit
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change dental benefit
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change vision benefit
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }


    }
}
