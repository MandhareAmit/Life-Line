using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace LifeLine
{
    public partial class Form1 : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["LifeLine.Properties.Settings.LifeLine"].ConnectionString;
        SqlConnection Con = new SqlConnection(constring);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PassTb.Text == "")
                MessageBox.Show("Enter a UserName And Password");
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from login where doctorName='" + DocNameTb.Text + "' and password='" + PassTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count == 1)
                    {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }  
               else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }
                Con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.ShowDialog();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
