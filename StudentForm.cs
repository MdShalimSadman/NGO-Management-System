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
    public partial class StudentForm : Form
    {
        string password;
        public StudentForm(string name, string nid, string phone, string address, string password)
        {
            InitializeComponent();
            lblStudentName1.Text = name;
            lblStudentName.Text = name;
            lblStudentNid.Text = nid;
            lblStudentPhone.Text = phone;
            lblStudentAddress.Text = address;
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
            SqlDataAdapter sqlDataAdapter = oProduct.showVolunteer();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            studentGridView.DataSource = dataTable;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateForm(lblStudentName.Text, lblStudentNid.Text, lblStudentPhone.Text, lblStudentAddress.Text, "Full Free Studentship", password).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.UserName = lblStudentName.Text;
            eproduct.NIDnumber = lblStudentNid.Text;
            eproduct.PhoneNumber = lblStudentPhone.Text;
            eproduct.Address = lblStudentAddress.Text;
            eproduct.PassWord = password;
            eproduct.Category = "Full Free Studentship";
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
