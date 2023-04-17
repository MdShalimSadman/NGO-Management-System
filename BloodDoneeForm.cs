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
    public partial class BloodDoneeForm : Form
    {
        string password;
        string bloodGroup;
        string district;
        public BloodDoneeForm(string name, string nid, string phone, string address, string password)
        {
            InitializeComponent();
            lblDoneeName1.Text = name;
            lblDoneeName.Text = name;
            lblDoneeNid.Text = nid;
            lblDoneePhone.Text = phone;
            lblDoneeAddress.Text = address;

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

        private void BloodDoneeForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.BloodGroup = bloodGroup;
            eproduct.District = district;
            Oproduct oProduct = new Oproduct();
            if (comboBox1.Text.Equals( "Show donors of blood groupI'm looking for"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showGroupedBloodDonor(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                donorGridView.DataSource = dataTable;
            }
            else if(comboBox1.Text.Equals("Show All donors"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showAllBloodDonor(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                donorGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text.Equals("Show donors of my district"))
            {
                SqlDataAdapter sqlDataAdapter = oProduct.showBloodDonorOfSameDistrict(eproduct);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                donorGridView.DataSource = dataTable;
            }

            else
            {
                MessageBox.Show("Please select an option from the list");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm u = new UpdateForm(lblDoneeName.Text, lblDoneeNid.Text, lblDoneePhone.Text, lblDoneeAddress.Text, "Blood Donee", password);
            u.setBloodGroup(bloodGroup);
            u.setDistrict(district);
            u.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.UserName = lblDoneeName.Text;
            eproduct.NIDnumber = lblDoneeNid.Text;
            eproduct.PhoneNumber = lblDoneePhone.Text;
            eproduct.Address = lblDoneeAddress.Text;
            eproduct.PassWord = password;
            eproduct.Category = "Blood Donee";
            Oproduct oproduct = new Oproduct();
            int number = oproduct.delete(eproduct);
            int number1 = oproduct.deleteBloodDonee(eproduct);
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangeBloodDoneeGroup b=new ChangeBloodDoneeGroup(lblDoneeName.Text, lblDoneeAddress.Text, lblDoneePhone.Text, lblDoneeAddress.Text, password, "Blood Donee");
            b.setDistrict(district);
            b.Show();
        }
    }
}
