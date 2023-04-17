using DataAccessLayerAll.entity;
using DataAccessLayerAll.operation;
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
    public partial class VolunteerForm : Form
    {
        string password;
        public VolunteerForm()
        {
            InitializeComponent();
        }
        public VolunteerForm(string name, string nid, string phone, string address, string password)
        {
            InitializeComponent();
            lblVolunteerName1.Text = name;
            lblVolunteerName.Text = name;
            lblVolunteerNid.Text = nid;
            lblVolunteerPhone.Text = phone;
            lblVolunteerAddress.Text = address;
            this.password = password;
        }

        private void linkLabelSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
          
                Oproduct oProduct = new Oproduct();
                SqlDataAdapter sqlDataAdapter = oProduct.showStudent();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                volunteerGridView.DataSource = dataTable;

            
        }

        private void VolunteerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateForm(lblVolunteerName.Text, lblVolunteerNid.Text, lblVolunteerPhone.Text, lblVolunteerAddress.Text, "Volunteer", password).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Eproduct eproduct = new Eproduct();
            eproduct.UserName = lblVolunteerName.Text;
            eproduct.NIDnumber = lblVolunteerNid.Text;
            eproduct.PhoneNumber = lblVolunteerPhone.Text;
            eproduct.Address = lblVolunteerAddress.Text;
            eproduct.PassWord = password;
            eproduct.Category = "Volunteer";
            Oproduct oproduct = new Oproduct();
            int number = oproduct.delete(eproduct);
            if (number > 0)
            {
                MessageBox.Show("Succesfully deleted");
                this.Hide();
                new LoginForm().Show();
            }
            else
            {
                MessageBox.Show("failed to delete ");
            }
        }
    }
}
