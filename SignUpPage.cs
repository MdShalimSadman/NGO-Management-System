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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Eproduct eproduct = new Eproduct();
            eproduct.UserName = txtUserName.Text;
            eproduct.NIDnumber = txtNid.Text;
            eproduct.PhoneNumber = txtPhoneNumber.Text;
            eproduct.Address = txtAddress.Text;
            eproduct.PassWord = txtPassword.Text;
            bool correctPhone = true;
            bool correctNid = true;
            bool correctUserName = true;
            for(int i = 0; i < txtPhoneNumber.Text.Length; i++)
            {
                if(!(txtPhoneNumber.Text[i]>='0' && txtPhoneNumber.Text[i] <= '9'))
                {
                    correctPhone = false;
                    
                }
            }
            for (int i = 0; i < txtNid.Text.Length; i++)
            {
                if (!(txtNid.Text[i] >= '0' && txtNid.Text[i] <= '9'))
                {
                    correctNid = false;

                }
            }
            //username:
            for (int i = 0; i < txtUserName.Text.Length; i++)
            {
                if ((txtUserName.Text[i] >= '0' && txtUserName.Text[i] <= '9')|| txtUserName.Text[i]=='+'|| txtUserName.Text[i]=='#'|| txtUserName.Text[i]=='$'|| txtUserName.Text[i]=='-'|| txtUserName.Text[i]=='*'|| txtUserName.Text[i]=='@'|| txtUserName.Text[i] == '^'|| txtUserName.Text[i] == '!'|| txtUserName.Text[i] == '%')
                {
                    correctUserName = false;

                }
            }


            if (chkAgreement.Checked == false)
            {
                MessageBox.Show("Please Accept Terms and Conditions ");
            }
            else if (correctUserName == false)
            {
                MessageBox.Show("Your username contains invalid characters");
            }
            else if (txtPhoneNumber.Text.Length > 11 || correctPhone==false)
            {
                MessageBox.Show("Incorrect Phone Number ");

            }
            else if (correctNid == false)
            {
                MessageBox.Show("Your NID / BRN contains invalid characters. Only numbers are supported ");
            }
            else if (!(txtPassword.Text.Equals(txtReEnterPassword.Text)) )
            {
                MessageBox.Show("Please Re-enter password correctly ");
            }
            else
            {
                if (rbtnVolunteer.Checked == true)
                {
                    eproduct.Category = rbtnVolunteer.Text;
                }
                else if (rbtnVolunteer1.Checked == true)
                {
                    eproduct.Category = rbtnVolunteer1.Text;
                    this.Hide();
                    VolunteerForm v = new VolunteerForm(txtUserName.Text, txtNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtPassword.Text);
                    v.Show();
                }
                else if (rbtnBloodDonor.Checked == true)
                {
                    eproduct.Category = rbtnBloodDonor.Text;
                    this.Hide();
                    BloodDonorGroupForm b = new BloodDonorGroupForm(txtUserName.Text, txtNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtPassword.Text);
                    b.Show();


                }
                else if (rbtnDoctor.Checked == true)
                {
                    eproduct.Category = rbtnDoctor.Text;
                    this.Hide();
                    SpecificationForm d = new SpecificationForm(txtUserName.Text, txtNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtPassword.Text,rbtnDoctor.Text);
                    d.Show();
                }
                else if (rbtnPatient.Checked == true)
                {
                    eproduct.Category = rbtnPatient.Text;
                    this.Hide();
                    SpecificationForm p = new SpecificationForm(txtUserName.Text, txtNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtPassword.Text, rbtnPatient.Text);
                    p.Show();
                }
                else if (rbtnStudent.Checked == true)
                {
                    eproduct.Category = rbtnStudent.Text;
                    this.Hide();
                    StudentForm s = new StudentForm(txtUserName.Text, txtNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtPassword.Text);
                    s.Show();



                }
                else if (rbtnBloodDonee.Checked == true)
                {
                    eproduct.Category = rbtnBloodDonee.Text;
                    this.Hide();
                    BloodDoneeGroupForm b = new BloodDoneeGroupForm(txtUserName.Text, txtNid.Text, txtPhoneNumber.Text, txtAddress.Text, txtPassword.Text);
                    b.Show();
                }


                Oproduct oproduct = new Oproduct();
                int number = oproduct.insert(eproduct);

                if (number > 0)
                {
                    MessageBox.Show("Succesfully inserted");
                }
                else
                {
                    MessageBox.Show("failed to insert");
                }
            }
            
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }
    }
}
