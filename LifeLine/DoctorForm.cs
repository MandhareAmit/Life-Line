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
    public partial class DoctorForm : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["LifeLine.Properties.Settings.LifeLine"].ConnectionString;
        SqlConnection Con = new SqlConnection(constring);
        public DoctorForm()
        {
            InitializeComponent();
        }
    void populate()
        {
            Con.Open();
            string query = "select * from DocTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        public void clear()
        {
            DocName.Text = "";
            docDegree.Text = "";
            DocExp.Text = "";           
            specification.Text = "";
            coouncialFees.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (docDegree.Text == "" || DocName.Text == "" || specification.Text == "" || DocExp.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = ("insert into DocTbl(docName,docExp,docDegree,specification,coouncialFees)" +
                    "values('" + DocName.Text + "','" + DocExp.Text + "','" +docDegree .Text + "','" + specification.Text + "','"+ coouncialFees.Text +"')");
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                Con.Close();
                populate();
                clear();
            }

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
            button2.Enabled = false;
            button3.Enabled = false;
            lblfees.Visible = false;
            lblspeci.Visible = false;
            lblExp.Visible = false;
            lblDName.Visible = false;
            lblDegree.Visible = false;
            docId.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (docDegree.Text == "")
                MessageBox.Show("Enter The Doctor Id");
            else
            {
                Con.Open();
                string query = "delete from DocTbl where DocId=" + docId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                Con.Close();
                populate();
                clear();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            docId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            docDegree.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            specification.Text = DoctorGV.SelectedRows[0].Cells[5].Value.ToString();
            coouncialFees.Text = DoctorGV.SelectedRows[0].Cells[6].Value.ToString();
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DocTbl set DocName = '" + DocName.Text + "',DocExp ='" + DocExp.Text + "',docDegree='" + docDegree.Text + "',specification='" + specification.Text + "',coouncialFees='" + coouncialFees.Text + "' where DocId=" + docId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully updated");
            Con.Close();
            populate();
            clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        //text box text
        private void DocName_MouseEnter(object sender, EventArgs e)
        {
            if (DocName.Text == "Doctor Name")
            {
                DocName.Text = "";
                lblDName.Visible = true;
            }
            
        }

      

        private void DocExp_MouseEnter(object sender, EventArgs e)
        {
            if (DocExp.Text == "Years Of Experience")
            {
                DocExp.Text = "";
                lblExp.Visible = true;
            }
            
        }

      

        private void docDegree_MouseEnter(object sender, EventArgs e)
        {
            if (docDegree.Text == "Degree")
            {
                docDegree.Text = "";
                lblDegree.Visible = true;
            }
           
        }

        private void specification_MouseEnter(object sender, EventArgs e)
        {
            if (specification.Text == "Specification")
            {
                specification.Text = "";
                lblspeci.Visible = true;
            }
        }

        private void coouncialFees_MouseEnter(object sender, EventArgs e)
        {
            if (coouncialFees.Text == "Counseling Fees")
            {
                coouncialFees.Text = "";
                lblfees.Visible = true;
            }
         
        }

        private void DocName_MouseLeave(object sender, EventArgs e)
        {
            if(DocName.Text == "")
            {
                DocName.Text = "Doctor Name";
                lblDName.Visible = false;
            }
        }

        private void DocExp_MouseLeave(object sender, EventArgs e)
        {
            if (DocExp.Text == "")
            {
                DocExp.Text = "Years Of Experience";
                lblExp.Visible = false;
            }
        }

        private void docDegree_MouseLeave(object sender, EventArgs e)
        {

            if (docDegree.Text == "")
            {
                docDegree.Text = "Degree";
                lblDegree.Visible = false;
            }
        }

        private void specification_MouseLeave(object sender, EventArgs e)
        {
            if (specification.Text == "")
            {
                specification.Text = "Specification";
                lblspeci.Visible = false;
            }
        }

        private void coouncialFees_MouseLeave(object sender, EventArgs e)
        {
            if (coouncialFees.Text == "")
            {
                coouncialFees.Text = "Counseling Fees";
                lblfees.Visible = false;
            }
        }
    }
}
