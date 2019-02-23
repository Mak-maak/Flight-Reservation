using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationApp
{
    public partial class InsEmployee : Form
    {
        public InsEmployee()
        {
            InitializeComponent();
        }

        private void InsEmployee_Load(object sender, EventArgs e)
        {
            // firstName events
            txtfName.GotFocus += new EventHandler(this.txtfNameGotFocus_Click);
            txtfName.LostFocus += new EventHandler(this.txtfNameLoseFocus_Click);

            // lastName events
            txtlName.GotFocus += new EventHandler(this.txtlNameGotFocus_Click);
            txtlName.LostFocus += new EventHandler(this.txtlNameLoseFocus_Click);

            // contact events
            txtContact.GotFocus += new EventHandler(this.txtContactGotFocus_Click);
            txtContact.LostFocus += new EventHandler(this.txtContactLoseFocus_Click);

            // city events
            txtCity.GotFocus += new EventHandler(this.txtCityGotFocus_Click);
            txtCity.LostFocus += new EventHandler(this.txtCityLoseFocus_Click);

            // address events
            txtAddress.GotFocus += new EventHandler(this.txtAddressGotFocus_Click);
            txtAddress.LostFocus += new EventHandler(this.txtAddressLoseFocus_Click);

            // job title events
            txtJobTitle.GotFocus += new EventHandler(this.txtJobTitleGotFocus_Click);
            txtJobTitle.LostFocus += new EventHandler(this.txtJobTitleLoseFocus_Click);

            // salary events
            txtSalary.GotFocus += new EventHandler(this.txtSalaryGotFocus_Click);
            txtSalary.LostFocus += new EventHandler(this.txtSalaryLoseFocus_Click);
        }

        // place holder class instantiation
        PlaceHolderText ph = new PlaceHolderText();

        // got focus event for firstName
        private void txtfNameGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtfName = (TextBox)sender;
            ph.OnFocus(txtfName, " First Name");
        }

        // lose focus event for firstName
        private void txtfNameLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtfName = (TextBox)sender;
            ph.LoseFocus(txtfName, " First Name");
        }

        // got focus event for last name
        private void txtlNameGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtlName = (TextBox)sender;
            ph.OnFocus(txtlName, " Last Name");
        }

        // lose focus event for lastName
        private void txtlNameLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtlName = (TextBox)sender;
            ph.LoseFocus(txtlName, " Last Name");
        }

        // got focus event for contact
        private void txtContactGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtContact = (TextBox)sender;
            ph.OnFocus(txtContact, " Contact No");
        }

        // lose focus event for contact
        private void txtContactLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtContact = (TextBox)sender;
            ph.LoseFocus(txtContact, " Contact No");
        }

        // got focus event for city
        private void txtCityGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtCity = (TextBox)sender;
            ph.OnFocus(txtCity, " City");
        }

        // lose focus event for city
        private void txtCityLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtCity = (TextBox)sender;
            ph.LoseFocus(txtCity, " City");
        }

        // got focus event for address
        private void txtAddressGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtAddress = (TextBox)sender;
            ph.OnFocus(txtAddress, " Address");
        }

        // lose focus event for address
        private void txtAddressLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtAddress = (TextBox)sender;
            ph.LoseFocus(txtAddress, " Address");
        }

        // got focus event for job title
        private void txtJobTitleGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtJobTitle = (TextBox)sender;
            ph.OnFocus(txtJobTitle, " Job Title");
        }

        // lose focus event for job title
        private void txtJobTitleLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtJobTitle = (TextBox)sender;
            ph.LoseFocus(txtJobTitle, " Job Title");
        }

        // got focus event for salary
        private void txtSalaryGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtSalary = (TextBox)sender;
            ph.OnFocus(txtSalary, " Salary");
        }

        // lose focus event for salary
        private void txtSalaryLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtSalary = (TextBox)sender;
            ph.LoseFocus(txtSalary, " Salary");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                empImg.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            empImg.Image = Properties.Resources.user_male_shape_in_a_circle_ios_7_interface_symbol_318_35357;
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            // check for null fields
            if ((txtfName.Text != null && txtfName.Text != " First Name") &&
                (txtlName.Text != null && txtlName.Text != " Last Name") &&
                txtContact.Text != null && txtContact.Text != " Contact" &&
                txtAddress.Text != null && txtAddress.Text != " Address" &&
                txtCity.Text != null && txtCity.Text != " City" &&
                txtSalary.Text != null && txtSalary.Text != " Salary" &&
                comboCountry.SelectedItem != null && (string)comboCountry.EditValue != "Country" &&
                txtJobTitle.Text != null && txtJobTitle.Text != " Job Title" &&
                comboDepart.SelectedItem != null && (string)comboDepart.EditValue != "Department"
                )
            {

                // instantiate customer class
                Employee emp = new Employee();

                // data binding
                emp.FirstName = txtfName.Text;
                emp.LastName = txtlName.Text;
                emp.ContactNo = txtContact.Text;
                emp.Country = comboCountry.Text;
                emp.City = txtCity.Text;
                emp.Address = txtAddress.Text;
                emp.Image = empImg.Image;
                emp.JobTitle = txtJobTitle.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                emp.Department = comboDepart.SelectedText;

                // selecting whether the gender is male or female
                if (rdbMale.Checked)
                {
                    emp.Gender = "Male";
                }
                if (rdbFemale.Checked)
                {
                    emp.Gender = "Female";
                }

                // show the please wait form until transaction gets done
                splashScreenManager1.ShowWaitForm();

                // loop through it
                for (byte b = 0; b <= 100; b++)
                {
                    Thread.Sleep(20);
                }

                // invoke method Save():void to save emp into database
                emp.Save();
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Record inserted successfully!", "Message");

                // return to the previous state of textboxes

                // setting the texts
                txtfName.Text = " First Name";
                txtlName.Text = " Last Name";
                txtContact.Text = " Contact No";
                txtCity.Text = " City";
                txtAddress.Text = " Address";
                txtJobTitle.Text = " Job Title";
                comboCountry.EditValue = "Country";
                comboDepart.EditValue = "Department";
                txtSalary.Text = " Salary";

                // setting the customer picture to null
                empImg.Image = Properties.Resources.user_male_shape_in_a_circle_ios_7_interface_symbol_318_35357;

                // setting color
                txtfName.ForeColor = Color.Gray;
                txtlName.ForeColor = Color.Gray;
                txtContact.ForeColor = Color.Gray;
                txtCity.ForeColor = Color.Gray;
                txtAddress.ForeColor = Color.Gray;
                txtJobTitle.ForeColor = Color.Gray;
                txtSalary.ForeColor = Color.Gray;
            }

            else
                MessageBox.Show("Error. Please fill the required fields and try again.", "Message Alert");
        }
    }
}
