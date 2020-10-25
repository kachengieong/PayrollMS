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
using System.Threading;

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
            textBox2.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimize the window when clicked
            if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (comboBox1.Text == string.Empty))
            {
                MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ieong\Source\Repos\PayrollMS1\Payrollredone2.accdb");
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Mastertable where ID=" + textBox1.Text + " and Password='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Login Succeed!");
                    Form2 HR = new Form2();
                    HR.Show();
                }
                else
                {
                    MessageBox.Show("Uncorrect username or password");
                }
            }
        }
    }
}
