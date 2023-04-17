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
    public partial class BloodDonorForm : Form
    {
        string password;
        string bloodGroup;
        string district;


        public BloodDonorForm(string name, string nid, string phone, string address, string password)
        {
            InitializeComponent();
            lblDonorName1.Text = name;
            lblDonorName.Text = name;
            lblDonorNid.Text = nid;
            lblDonorPhone.Text = phone;
            lblDonorAddress.Text = address;
            
            this.password = password;
        }
        public void setBloodGroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
            lblBloodGroup.Text = bloodGroup;
        }
        public string getBloodGroup()
        {
            return bloodGroup;
        }
        public void setDistrict(string district)
        {
            this.district = district;
            lblDistrict.Text = district;
        }
        public string getDistrict()
        {
            return district;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm u= new UpdateForm(lblDonorName.Text, lblDonorNid.Text, lblDonorPhone.Text, lblDonorAddress.Text, "Blood Donor", password);
            u.setBloodGroup(bloodGroup);
            u.setDistrict(district);
            u.Show();

        }

        private void BloodDonorForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.UserName = lblDonorName.Text;
            eproduct.NIDnumber = lblDonorNid.Text;
            eproduct.PhoneNumber = lblDonorPhone.Text;
            eproduct.Address = lblDonorAddress.Text;
            eproduct.PassWord = password;
            eproduct.Category = "Blood Donor";
            Oproduct oproduct = new Oproduct();
            int number = oproduct.delete(eproduct);
            int number1 = oproduct.deleteBloodDonor(eproduct);
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.BloodGroup = bloodGroup;
            eproduct.District = district;
            Oproduct oProduct = new Oproduct();
            if (comboBox1.Text.Equals("Show donees of blood groupI'm looking for"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showGroupedBloodDonee(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                doneeGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text.Equals("Show All donees"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showAllBloodDonee(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                doneeGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text.Equals("Show donees of my district"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showBloodDoneeOfSameDistrict(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                doneeGridView.DataSource = dataTable;
            }

            else
            {
                MessageBox.Show("Please select an option from the list");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangeBloodDoneeGroup b=new ChangeBloodDoneeGroup(lblDonorName.Text, lblDonorAddress.Text, lblDonorPhone.Text, lblDonorAddress.Text, password, "Blood Donor");
            b.setDistrict(district);
            b.Show();

        }
    }
}
