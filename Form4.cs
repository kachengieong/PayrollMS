using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ieong/Source/Repos/PayrollMS1/Payrollredone2.accdb");
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Economictable WHERE ID = " + textBox1.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
                MessageBox.Show("Employee Record Deleted");
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //sql connection
            OleDbConnection con1 = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:/Users/ieong/Source/Repos/PayrollMS1/Payrollredone2.accdb");
            con1.Open();
            //check if the employee id is found:
            //data from HRView:
            OleDbDataReader myReader = null;
            OleDbCommand myCommand = new OleDbCommand("select * from HRView where ID =" + int.Parse(textBox1.Text), con1);
            //DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            //da.Fill(dt);
            //if (dt.Rows.Count == 1)
            //{
                myReader = myCommand.ExecuteReader();

                //read data from database into gui form 4:
                while (myReader.Read())
                {
                    label16.Text = (myReader["Firstname"].ToString());
                    label20.Text = (myReader["Lastname"].ToString());
                    label21.Text = (myReader["DateofBirth"].ToString());

                    textBox7.Text = (myReader["Email"].ToString());
                    textBox8.Text = (myReader["PhoneNumber"].ToString());
                    textBox9.Text = (myReader["Address"].ToString());
                    textBox10.Text = (myReader["Address2"].ToString());
                    textBox11.Text = (myReader["ZipCode"].ToString());
                    textBox3.Text = (myReader["Department"].ToString());
                    textBox4.Text = (myReader["Position"].ToString());
                    dateTimePicker2.Text = (myReader["Datehired"].ToString());
                    //comboBox1.SelectedItem.Text = (myReader["HealthCover"].ToString());
                    //comboBox2.SelectedItem.Text = (myReader["DentalCover"].ToString());
                    //comboBox3.SelectedItem.Text = (myReader["VisionCover"].ToString());

            }
            //else
            //{
            //    MessageBox.Show("The ID you inputted did not exist in the database");
            //}
            OleDbCommand myCommand1 = new OleDbCommand("select * from Economictable where ID =" + int.Parse(textBox1.Text), con1);
            //DataTable dt1 = new DataTable();
            //OleDbDataAdapter da1 = new OleDbDataAdapter(myCommand);
            //da1.Fill(dt1);
            //if (dt.Rows.Count == 1)
            //{
                myReader = myCommand1.ExecuteReader();

                //read data from database into gui form 4:
                while (myReader.Read())
                {
                    textBox2.Text = (myReader["Hours"].ToString());
                    textBox5.Text = (myReader["Weeklygrosspay"].ToString());
                    textBox6.Text = (myReader["HourlyPay"].ToString());
                }
            }
            //else
            //{
            //    MessageBox.Show("The ID you inputted did not exist in the database");
            //}
        }
}
