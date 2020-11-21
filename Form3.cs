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
            textBox13.Enabled = radioButton4.Checked;
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
            int overtimeHour = GrossIncome.CalculateOvertimeHour(int.Parse(textBox13.Text));
            double overtimePay = GrossIncome.CalculateOvertimePay(overtimeHour, Convert.ToDouble(textBox6.Text));
            double grossIncome = GrossIncome.CalculateGrossIncome(int.Parse(textBox13.Text), overtimePay, Convert.ToDouble(textBox6.Text));
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ieong/Source/Repos/PayrollMS1/Payrollredone2.accdb");
            conn.Open();
            if (radioButton3.Checked)
            {
                string typetext = radioButton3.Text;
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Economictable (ID, Firstname, Lastname, Occupation, Weeklygrosspay, Paytime) VALUES ('" + int.Parse(textBox14.Text) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '"+ Convert.ToDouble(textBox5.Text) + "', '"  + typetext + "')";
                cmd.ExecuteNonQuery();
            }
            else if (radioButton4.Checked)
            {
                string typetext = radioButton4.Text;
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Economictable (ID, Firstname, Lastname, Occupation, Hours, OvertimeHours, Overtimepay, Weeklygrosspay, HourlyPay, Paytime) VALUES ('" + int.Parse(textBox14.Text) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '" + (int.Parse(textBox13.Text) - overtimeHour) + "', '" + overtimeHour + "', '" + overtimePay + "', '" + grossIncome + "', '" + Convert.ToDouble(textBox6.Text) + "', '" + typetext +"')";
                cmd.ExecuteNonQuery();
            }
            OleDbCommand addCommand = conn.CreateCommand();
            addCommand.CommandType = CommandType.Text;
            //to choose gender radio button:
            string gendertext = "";
            if (radioButton1.Checked)
            {
                gendertext = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gendertext = radioButton2.Text;
            }
            addCommand.CommandText = "INSERT INTO HRView (ID, Firstname, Lastname, DateofBirth, Age, Gender,Department, Occupation, Datehired, HealthPlan, DentalCoverage, VisionCoverage, Email, PhoneNumber, Address, Address2, ZipCode) VALUES ('" + 
                int.Parse(textBox14.Text) + "', '" + textBox1.Text + "', '"+ textBox2.Text + "', '" + dateTimePicker1.Value + "', '" + int.Parse(textBox12.Text) + "', '" + gendertext + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker2.Value + "', '" + comboBox1.Text + 
                "', '" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "')";
            addCommand.ExecuteNonQuery();
            if (radioButton3.Checked)
            {
                string typetext = radioButton3.Text;
                OleDbCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Mastertable (Weeklygrosspay, Paytime, Firstname, Lastname, DateofBirth, Age, Gender,Department, Occupation, Datehired, HealthPlan, DentalCoverage, VisionCoverage, Email, PhoneNumber, Address, Address2, ZipCode, ID, Password) VALUES ('"
                    + "', '" + Convert.ToDouble(textBox5.Text) + "', '" + typetext + textBox1.Text + "', '" + textBox2.Text + "', '" + dateTimePicker1.Value + "', '" +
                    int.Parse(textBox12.Text) + "', '" + gendertext + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker2.Value + "', '" + comboBox1.Text + "', '"
                    + comboBox2.Text + "', '" + comboBox3.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "', '" + int.Parse(textBox14.Text) + "', '"  + textBox15.Text +"')";
                command.ExecuteNonQuery();
            }
            else if (radioButton4.Checked)
            {
                string typetext = radioButton4.Text;
                OleDbCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Mastertable (Hours, OvertimeHours, Overtimepay, Weeklygrosspay, HourlyPay, Paytime, Firstname, Lastname, DateofBirth, Age, Gender,Department, Occupation, Datehired, HealthPlan, DentalCoverage, VisionCoverage, Email, PhoneNumber, Address, Address2, ZipCode, ID, Password) VALUES ('"
                    + (int.Parse(textBox13.Text) - overtimeHour) + "', '" + overtimeHour + "', '" + overtimePay + "', '" + grossIncome + "', '" + Convert.ToDouble(textBox6.Text) + "', '" + typetext + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + dateTimePicker1.Value + "', '" +
                    int.Parse(textBox12.Text) + "', '" + gendertext + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker2.Value + "', '" + comboBox1.Text + "', '"
                    + comboBox2.Text + "', '" + comboBox3.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "', '" + int.Parse(textBox14.Text) + "', '" + textBox15.Text + "')";
                command.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("Add Succeed!");
            this.Close();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
