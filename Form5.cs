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
            //to get the emplid from login form:
            label31.Text = Form1.SetValueForText1;
            this.TopMost = true;


            //database connection
            OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ieong\Source\Repos\PayrollMS1\payrollSystem.accdb");
            con1.Open();

            //retrieve info from databse based on empl id
            OleDbDataReader myReader = null;
            OleDbCommand myCommand = new OleDbCommand("select * from HRView where ID =" + label31.Text, con1);

            myReader = myCommand.ExecuteReader();

            //read data from database into gui form 4:
            while (myReader.Read())
            {

                label1.Text = (myReader["Firstname"].ToString());
                label2.Text = (myReader["Lastname"].ToString());
                label4.Text = (myReader["Gender"].ToString());
                label15.Text = (myReader["Department"].ToString());
                label16.Text = (myReader["Position"].ToString());
                //label20.Text = (myReader["IncomeType"].ToString());
                // label21.Text = (myReader["GrossIncome"].ToString());
                label24.Text = (myReader["HealthPlan"].ToString());
                label33.Text = (myReader["Status"].ToString());


            }
            
            OleDbCommand myCommand1 = new OleDbCommand("select * from Mastertable where ID =" + label31.Text, con1);

            myReader = myCommand1.ExecuteReader();

            //read data from database into gui form 5:
            while (myReader.Read())
            {

                label20.Text = (myReader["Paytime"].ToString());
                 label25.Text = (myReader["DentalCoverage"].ToString());
                label26.Text = (myReader["VisionCoverage"].ToString());
                label3.Text = (myReader["DateofBirth"].ToString());


            }

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 coworker = new Form6();
            coworker.Show();
        }
    }
}
