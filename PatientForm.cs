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
    public partial class PatientForm : Form
    {
        string password;
        string specification;
        public PatientForm(string name, string nid, string phone, string address, string password)
        {
            InitializeComponent();
            lblPatientName1.Text = name;
            lblPatientName.Text = name;
            lblPatientNid.Text = nid;
            lblPatientPhone.Text = phone;
            lblPatientAddress.Text = address;
            this.password = password;
        }
        public void setSpecification(string specification)
        {
            this.specification = specification;
            lblSpecification.Text = specification;
        }
        public string getSpecificaion()
        {
            return specification;
        }
        private void linkLabelSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.Specification = specification;
            Oproduct oProduct = new Oproduct();
            if (comboBox1.Text.Equals("show all doctors"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showDoctor();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                doctorGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text.Equals("show doctors of the specification I'm looking for"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showSpecificDoctor(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                doctorGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Please select an option from the list");
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm u = new UpdateForm(lblPatientName.Text, lblPatientNid.Text, lblPatientPhone.Text, lblPatientAddress.Text, "Patient", password);
            u.setSpecification(specification);
            u.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.UserName = lblPatientName.Text;
            eproduct.NIDnumber = lblPatientNid.Text;
            eproduct.PhoneNumber = lblPatientPhone.Text;
            eproduct.Address = lblPatientAddress.Text;
            eproduct.PassWord = password;
            eproduct.Category = "Patient";
            Oproduct oproduct = new Oproduct();
            int number = oproduct.delete(eproduct);
            int number1 = oproduct.deletePatient(eproduct);
            if (number > 0 && number1>0)
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
