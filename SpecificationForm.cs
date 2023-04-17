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
    public partial class SpecificationForm : Form
    {
        string name;
        string nid;
        string phone;
        string address;
        string password;
        string category;
        public SpecificationForm(string name, string nid, string phone, string address, string password, string category)
        {
            InitializeComponent();
            this.name = name;
            this.nid = nid;
            this.phone = phone;
            this.address = address;
            this.password = password;
            this.category = category;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SpecificationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Please insert the specification");
            }
            else
            {
                Eproduct eproduct = new Eproduct();
                eproduct.UserName = name;
                eproduct.NIDnumber = nid;
                eproduct.PhoneNumber = phone;
                eproduct.Address = address;
                eproduct.Specification = comboBox1.Text;
                if (category == "Doctor")
                {
                    Oproduct oproduct = new Oproduct();
                    int number = oproduct.insertDoctor(eproduct);
                    this.Hide();
                    DoctorForm d = new DoctorForm(name, nid, phone, address, password);
                    d.setSpecification(comboBox1.Text);
                    d.Show();
                    if (number > 0)
                    {
                        MessageBox.Show("Succesfully inserted");
                    }
                    else
                    {
                        MessageBox.Show("failed to insert");
                    }
                }
                else if (category == "Patient")
                {
                    Oproduct oproduct = new Oproduct();
                    int number = oproduct.insertPatient(eproduct);
                    this.Hide();
                    PatientForm p = new PatientForm(name, nid, phone, address, password);
                    p.setSpecification(comboBox1.Text);
                    p.Show();
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
        }
    }
}
