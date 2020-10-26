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
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //OleDbConnection con1 = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:/Users/ieong/Source/Repos/PayrollMS1/Payrollredone2.accdb");
            //con1.Open();
            //check if the employee id is found:
            //data from HRView:
            //OleDbDataReader myReader = null;
            //OleDbCommand myCommand = new OleDbCommand("select * from HRView where ID = '" + label31.Text + "'", con1);
            //DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            //da.Fill(dt);
            //if (dt.Rows.Count == 1)
            //{
            //myReader = myCommand.ExecuteReader();

            ////read data from database into gui form 4:
            //while (myReader.Read())
            //{
            //    label1.Text = (myReader["Firstname"].ToString());
            //    label2.Text = (myReader["Lastname"].ToString());
                //label21.Text = (myReader["DateofBirth"].ToString());

                //textBox7.Text = (myReader["Email"].ToString());
                //textBox8.Text = (myReader["PhoneNumber"].ToString());
                //textBox9.Text = (myReader["Address"].ToString());
                //textBox10.Text = (myReader["Address2"].ToString());
                //textBox11.Text = (myReader["ZipCode"].ToString());
                //textBox3.Text = (myReader["Department"].ToString());
                //textBox4.Text = (myReader["Position"].ToString());
                //comboBox1.SelectedItem.Text = (myReader["HealthCover"].ToString());
                //comboBox2.SelectedItem.Text = (myReader["DentalCover"].ToString());
                //comboBox3.SelectedItem.Text = (myReader["VisionCover"].ToString());

                //}
                //else
                //{
                //    MessageBox.Show("The ID you inputted did not exist in the database");
                //}
                //OleDbCommand myCommand1 = new OleDbCommand("select * from Economictable where ID =" + int.Parse(textBox1.Text), con1);
                ////DataTable dt1 = new DataTable();
                ////OleDbDataAdapter da1 = new OleDbDataAdapter(myCommand);
                ////da1.Fill(dt1);
                ////if (dt.Rows.Count == 1)
                ////{
                //myReader = myCommand1.ExecuteReader();

                ////read data from database into gui form 4:
                //while (myReader.Read())
                //{
                //    textBox2.Text = (myReader["Hours"].ToString());
                //    textBox5.Text = (myReader["Weeklygrosspay"].ToString());
                //    textBox6.Text = (myReader["HourlyPay"].ToString());
                //}
                //else
                //{
                //    MessageBox.Show("The ID you inputted did not exist in the database");
                //}
            //}
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
