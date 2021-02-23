using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.Configuration;

namespace LifeLine
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        static string constring = ConfigurationManager.ConnectionStrings["LifeLine.Properties.Settings.LifeLine"].ConnectionString;
        SqlConnection Con = new SqlConnection(constring);
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE doctorName=@doctorName", Con);
            cmd.Parameters.AddWithValue("@doctorName", txtusername.Text.ToLower());
            Con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter User Name");
            }
            else if(txtpass.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else if (dr.HasRows)
            {
                MessageBox.Show("user Name already Exists");
            }
            else
            {
                Con.Open();
                string query = ("insert into login(doctorName,password) values('" + txtusername.Text + "','" + txtpass.Text + "')");
                SqlCommand Cmd = new SqlCommand(query, Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();                
            }
            clear();
        }

        public void clear()
        {
            txtusername.Text = "";
            txtpass.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 l = new Form1();
            l.ShowDialog();
        }
    }
}
