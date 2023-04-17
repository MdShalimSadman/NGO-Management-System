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
    public partial class UpdateForm : Form
    {
        string currentName;
        string nid;
        string currentPhone;
        string currentAdress;
        string category;
        string currentPassword;
        string bloodGroup;
        string district;
        string specification;
       
        public UpdateForm(string name, string nid, string phone, string address,string category,string password)
        {
            InitializeComponent();
            currentName = name;
            txtUserName.Text = name;
            this.nid = nid;
            lblFixedNid.Text = nid;
            currentPhone = phone;
            txtPhoneNumber.Text = phone;
            currentAdress = address;
            txtAddress.Text = address;
            this.category = category;
            lblFixedCategory.Text = category;
            currentPassword = password;
        }

        //For Blood Donor: 
        public void setBloodGroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
        }
        public string getBloodGroup()
        {
            return bloodGroup;
        }
        public void setDistrict(string district)
        {
            this.district = district;
           
        }
        public string getDistrict()
        {
            return district;
        }

        //For Doctor:
        public void setSpecification(string specification)
        {
            this.specification = specification;

        }
        public string getSpecification()
        {
            return specification;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.UserName = txtUserName.Text;
            eproduct.NIDnumber = lblFixedNid.Text;
            eproduct.PhoneNumber = txtPhoneNumber.Text;
            eproduct.Address = txtAddress.Text;
            eproduct.PassWord = txtNewPassword.Text;
            eproduct.Category = lblFixedCategory.Text;

            //for blood donor:
            eproduct.BloodGroup = bloodGroup;

            bool correctPhone = true;

            for (int i = 0; i < txtPhoneNumber.Text.Length; i++)
            {
                if (!(txtPhoneNumber.Text[i] >= '0' && txtPhoneNumber.Text[i] <= '9'))
                {
                    correctPhone = false;

                }
            }

            if (!(txtCurrentPassword.Text.Equals(currentPassword)))
            {
                MessageBox.Show("Please enter your current password correctly ");
            }
            else if (!(txtNewPassword.Text.Equals(textReEnterPassword.Text)))
            {
                MessageBox.Show("Please Re-enter new password correctly ");
            }
            else if (txtPhoneNumber.Text.Length > 11 || correctPhone == false)
            {
                MessageBox.Show("Incorrect Phone Number ");

            }
            else
            {
                Oproduct oproduct = new Oproduct();
                int number = oproduct.update(eproduct);
                if (number > 0)
                {
                    MessageBox.Show("Succesfully updated");
                }
                else
                {
                    MessageBox.Show("failed to update ");
                }

                if (lblFixedCategory.Text == "Doctor")
                {
                    this.Hide();
                    DoctorForm b = new DoctorForm(txtUserName.Text, lblFixedNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtNewPassword.Text);
                    b.setSpecification(specification);
                   
                    int number1 = oproduct.updateDoctor(eproduct);
                    b.Show();
                    if (number1 > 0)
                    {
                        MessageBox.Show("Succesfully updated in doctor table");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update in doctor table ");
                    }
                }
                else if (lblFixedCategory.Text == "Patient")
                {
                    this.Hide();
                    PatientForm p= new PatientForm(txtUserName.Text, lblFixedNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtNewPassword.Text);
                    p.setSpecification(specification);
                    int number1 = oproduct.updatePatient(eproduct);
                    p.Show();
                    if (number1 > 0)
                    {
                        MessageBox.Show("Succesfully updated in Patient table");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update in Patient table ");
                    }

                }
                else if (lblFixedCategory.Text == "Volunteer")
                {
                    this.Hide();
                    new VolunteerForm(txtUserName.Text, lblFixedNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtNewPassword.Text).Show();
                }
                else if (lblFixedCategory.Text == "Blood Donor")
                {
                    this.Hide();
                    BloodDonorForm b=new BloodDonorForm(txtUserName.Text, lblFixedNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtNewPassword.Text);
                    b.setBloodGroup(bloodGroup);
                    b.setDistrict(district);
                    int number1 = oproduct.updateBloodDonor(eproduct);
                    b.Show();
                    if (number1 > 0)
                    {
                        MessageBox.Show("Succesfully updated in blood donor table");
                    }
                    
                }
                else if (lblFixedCategory.Text == "Blood Donee")
                {
                    this.Hide();
                    BloodDoneeForm b = new BloodDoneeForm(txtUserName.Text, lblFixedNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtNewPassword.Text);
                    b.setBloodGroup(bloodGroup);
                    b.setDistrict(district);
                    int number1 = oproduct.updateBloodDonee(eproduct);
                    b.Show();
                    if (number1 > 0)
                    {
                        MessageBox.Show("Succesfully updated in blood donee table");
                    }


                }
                else if (lblFixedCategory.Text == "Full Free Studentship")
                {
                    this.Hide();
                    new StudentForm(txtUserName.Text, lblFixedNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtNewPassword.Text).Show();
                }
               

            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void txtNid_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (category == "Doctor")
            {
                this.Hide();
                DoctorForm d = new DoctorForm(currentName, nid, currentPhone, currentAdress, currentPassword);
                d.setSpecification(specification);
                d.Show();
            }
            else if (category == "Patient")
            {
                this.Hide();
                PatientForm p = new PatientForm(currentName, nid, currentPhone, currentAdress, currentPassword);
                p.setSpecification(specification);
                p.Show();
            }
            else if (category == "Volunteer")
            {
                this.Hide();
                VolunteerForm v = new VolunteerForm(currentName, nid, currentPhone, currentAdress, currentPassword);

                v.Show();
            }
            else if (category == "Full Free Studentship")
            {
                this.Hide();
                StudentForm s = new StudentForm(currentName, nid, currentPhone, currentAdress, currentPassword);

                s.Show();
            }
            else if (category == "Blood Donor")
            {
                this.Hide();
                BloodDonorForm b = new BloodDonorForm(currentName, nid, currentPhone, currentAdress, currentPassword);
                b.setBloodGroup(bloodGroup);
                b.setDistrict(district);
                b.Show();
            }
            else if (category == "Blood Donee")
            {
                this.Hide();
                BloodDoneeForm b = new BloodDoneeForm(currentName, nid, currentPhone, currentAdress, currentPassword);
                b.setBloodGroup(bloodGroup);
                b.setDistrict(district);
                b.Show();
            }
        }
    }
}
