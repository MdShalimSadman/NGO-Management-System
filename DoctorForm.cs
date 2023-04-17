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
    public partial class DoctorForm : Form
    {
        string password;
        string specification;
        public DoctorForm(string name, string nid, string phone, string address,string password)
        {
            InitializeComponent();
            lblDoctorName1.Text = name ;
            lblDoctorName.Text = name;
            lblDoctorNid.Text = nid;
            lblDoctorPhone.Text = phone;
            lblDoctorAddress.Text = address;
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
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {
           

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = new Eproduct().UserName;
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm u = new UpdateForm(lblDoctorName.Text, lblDoctorNid.Text, lblDoctorPhone.Text, lblDoctorAddress.Text, "Doctor", password);
            u.setSpecification(specification);
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.UserName = lblDoctorName.Text;
            eproduct.NIDnumber = lblDoctorNid.Text;
            eproduct.PhoneNumber = lblDoctorPhone.Text;
            eproduct.Address = lblDoctorAddress.Text;
            eproduct.PassWord = password;
            eproduct.Category = "Doctor";
            Oproduct oproduct = new Oproduct();
            int number = oproduct.delete(eproduct);
            int number1 = oproduct.deleteDoctor(eproduct);
            if (number > 0 && number1 > 0) 
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.Specification = specification;
            Oproduct oProduct = new Oproduct();
            if (comboBox1.Text.Equals("show all patients"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showPatient();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                doctorGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text.Equals("show patients of the specification I'm looking for"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showSpecificPatient(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                doctorGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Please select an option from the list");
            }

        }

        private void txtDocName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDoctorName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
