using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUpPage().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNGOmanagementSystem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=AllMembersInformation;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From AllMemberTable where PhoneNumber ='" +txtPhoneNumber.Text+ "' and Password ='"+txtPassword.Text+" ' ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if(dt.Rows.Count ==1)
            {
                this.Hide();
                
                string userName = dt.Rows[0]["UserName"].ToString();
                string nid = dt.Rows[0]["NIDnumber"].ToString();
                string phoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                string address = dt.Rows[0]["Address"].ToString();
                string password = dt.Rows[0]["Password"].ToString();
                string category = dt.Rows[0]["Category"].ToString();
                if (category == "Doctor")
                {
                    DoctorForm d = new DoctorForm(userName, nid, phoneNumber, address, password);
                    d.Show();
                    SqlDataAdapter don = new SqlDataAdapter("Select * From DoctorTable where NIDnumber ='" + nid + " ' ", connection);
                    DataTable dt1 = new DataTable();
                    don.Fill(dt1);
                    string specification = dt1.Rows[0]["Specification"].ToString();

                    d.setSpecification(specification);
                   
                }
                else if (category == "Patient")
                {
                    PatientForm p = new PatientForm(userName, nid, phoneNumber, address, password);
                    p.Show();
                    SqlDataAdapter don = new SqlDataAdapter("Select * From PatientTable where NIDnumber ='" + nid + " ' ", connection);
                    DataTable dt1 = new DataTable();
                    don.Fill(dt1);
                    string specification = dt1.Rows[0]["Specification"].ToString();

                    p.setSpecification(specification);
                }
                else if (category == "Volunteer")
                {
                    new VolunteerForm(userName, nid, phoneNumber, address, password).Show();
                }
                else if (category == "Full Free Studentship")
                {
                    new StudentForm(userName, nid, phoneNumber, address, password).Show();
                }
                else if (category == "Blood Donor")
                {
                    BloodDonorForm d= new BloodDonorForm(userName, nid, phoneNumber, address, password);
                    d.Show();
                   
                    SqlDataAdapter don = new SqlDataAdapter("Select * From BloodDonorTable where NIDnumber ='" + nid + " ' ", connection);
                    DataTable dt1 = new DataTable();
                    don.Fill(dt1);
                    string bloodGroup = dt1.Rows[0]["BloodGroup"].ToString();
                    string district = dt1.Rows[0]["District"].ToString();
                    d.setBloodGroup(bloodGroup);
                    d.setDistrict(district);

                }
                else if (category == "Blood Donee")
                {
                    BloodDoneeForm d = new BloodDoneeForm(userName, nid, phoneNumber, address, password);
                    d.Show();

                    SqlDataAdapter don = new SqlDataAdapter("Select * From BloodDoneeTable where NIDnumber ='" + nid + " ' ", connection);
                    DataTable dt1 = new DataTable();
                    don.Fill(dt1);
                    string bloodGroup = dt1.Rows[0]["BloodGroup"].ToString();
                    string district = dt1.Rows[0]["District"].ToString();
                    d.setBloodGroup(bloodGroup);
                    d.setDistrict(district);

                }
                MessageBox.Show("login succesfull");



            }
            else
            {
                MessageBox.Show("Please check your Phone number and password");
            }
            connection.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CreditForm().Show();
        }
    }
}
