using DataAccessLayerAll.entity;
using DataAccessLayerAll.operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_login
{
    public partial class ChangeBloodDoneeGroup : Form
    {
        string name;
        string nid;
        string phone;
        string address;
        string password;
        string category;
        string district;
        public ChangeBloodDoneeGroup(string name, string nid, string phone, string address, string password,string category)
        {
            InitializeComponent();
            this.name = name;
            this.nid = nid;
            this.phone = phone;
            this.address = address;
            this.password = password;
            this.category=category;
        }
        public void setDistrict(string district)
        {
            this.district = district;
           
        }
        public string getDistrict()
        {
            return district;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Please insert your blood group");
            }
            else
            {
                Eproduct eproduct = new Eproduct();
                eproduct.UserName = name;
                eproduct.NIDnumber = nid;
                eproduct.PhoneNumber = phone;
                eproduct.Address = address;
                eproduct.BloodGroup = comboBox1.Text;
                if (category == "Blood Donee")
                {
                    Oproduct oproduct = new Oproduct();
                    int number = oproduct.BloodDoneeChangeGroup(eproduct);
                    this.Hide();
                    BloodDoneeForm b = new BloodDoneeForm(name, nid, phone, address, password);
                    b.setBloodGroup(comboBox1.Text);
                    b.setDistrict(district);
                    b.Show();

                    if (number > 0)
                    {
                        MessageBox.Show("Succesfully updated");
                    }
                    else
                    {
                        MessageBox.Show("failed to update");
                    }
                }
                else if (category == "Blood Donor")
                {
                    Oproduct oproduct = new Oproduct();
                    int number = oproduct.BloodDonorChangeGroup(eproduct);
                    this.Hide();
                    BloodDonorForm b = new BloodDonorForm(name, nid, phone, address, password);
                    b.setBloodGroup(comboBox1.Text);
                    b.setDistrict(district);
                    b.Show();

                    if (number > 0)
                    {
                        MessageBox.Show("Succesfully updated");
                    }
                    else
                    {
                        MessageBox.Show("failed to update");
                    }
                }
            }
        }

        private void ChangeBloodDoneeGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
