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
using MetroFramework;

namespace LifeLine
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
        static string constring = ConfigurationManager.ConnectionStrings["LifeLine.Properties.Settings.LifeLine"].ConnectionString;
        SqlConnection Con = new SqlConnection(constring);
        void populate()
        {
            Con.Open();
            string query = "select * from Patient";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "" || PatAd.Text == "" || PatPhone.Text == "" || PatAge.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }                
            else
            {
                Con.Open();
                string query = ("insert into Patient(PatName,PatAddress,PatPhone,PatAge,PatGender,PatBlood,PatDisease)" +
                    "values('" + PatName.Text + "','" + PatAd.Text + "','" + PatPhone.Text + "','" + PatAge.Text + "','" + GenderCb.Text + "','" + BloodCb.Text + "','" + MajorTb.Text + "')");
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
                populate();
                
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
            PatId.Visible = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter The Patient Id");
            else
            {
                Con.Open();
                string query = "delete from Patient where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            MajorTb.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
            button2.Enabled = true;
            button3.Enabled = true;
            PatId.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update Patient set PatName = '" + PatName.Text + "',PatAddress ='" + PatAd.Text + "',PatPhone='" + PatPhone.Text + "',PatAge='" + PatAge.Text + "',PatGender='" + GenderCb.Text + "',PatBlood='" + BloodCb.Text + "',PatDisease='" + MajorTb.Text + "' where PatId=" + PatId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Successfully updated");
            Con.Close();
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
