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
    public partial class BloodDoneeGroupForm : Form
    {
        string name;
        string nid;
        string phone;
        string address;
        string password;
        public BloodDoneeGroupForm(string name, string nid, string phone, string address, string password)
        {
            InitializeComponent();
            this.name = name;
            this.nid = nid;
            this.phone = phone;
            this.address = address;
            this.password = password;
        }

        private void BloodDoneeGroupForm_Load(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Please insert your blood group");
            }
            else if (comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Please insert your district ");
            }
            else
            {
                Eproduct eproduct = new Eproduct();
                eproduct.UserName = name;
                eproduct.NIDnumber = nid;
                eproduct.PhoneNumber = phone;
                eproduct.Address = address;
                eproduct.BloodGroup = comboBox1.Text;
                eproduct.District = comboBox2.Text;
                Oproduct oproduct = new Oproduct();
                int number = oproduct.insertBloodDonee(eproduct);
                this.Hide();
                BloodDoneeForm b = new BloodDoneeForm(name, nid, phone, address, password);
                b.setBloodGroup(comboBox1.Text);
                b.setDistrict(comboBox2.Text);
                b.Show();
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
