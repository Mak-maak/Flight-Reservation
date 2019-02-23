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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // instantiate place holder class
        PlaceHolderText ph = new PlaceHolderText();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adults_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

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

        // got focus event for contact
        private void txtDestinationGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtDestination = (TextBox)sender;
            ph.OnFocus(txtDestination, " Destination");
        }

        // lose focus event for contact
        private void txtDestinationLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtDestination = (TextBox)sender;
            ph.LoseFocus(txtDestination, " Destination");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                customerImg.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            customerImg.Image = Properties.Resources.user_male_shape_in_a_circle_ios_7_interface_symbol_318_35357;
        }

        private void Form2_Load(object sender, EventArgs e)
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

            // destination events
            txtDestination.GotFocus += new EventHandler(this.txtDestinationGotFocus_Click);
            txtDestination.LostFocus += new EventHandler(this.txtDestinationLoseFocus_Click);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // check for null fields
            if (txtfName.Text != null &&
                txtlName.Text != null &&
                txtContact.Text != null &&
                txtAddress.Text != null &&
                txtCity.Text != null &&
                comboCountry.SelectedItem != null &&
                comboClass.SelectedItem != null &&
                comboDepartureAirport.SelectedItem != null &&
                dateTimePicker1Departure.Value != null &&
                txtDestination.Text != null &
                no_of_Adults.Value > 0
                )
            {

                // instantiate customer class
                Customer customer = new Customer();

                // data binding
                customer.CustomerName = txtfName.Text + txtlName.Text;
                customer.ContactNo = txtContact.Text;
                customer.Country = comboCountry.Text;
                customer.City = txtCity.Text;
                customer.Address = txtAddress.Text;
                customer.Image = customerImg.Image;

                // selecting whether the gender is male or female
                if (rdbMale.Checked)
                {
                    customer.Gender = "Male";
                }
                if (rdbFemale.Checked)
                {
                    customer.Gender = "Female";
                }

                // show the please wait form until transaction gets done
                splashScreenManager1.ShowWaitForm();

                // loop through it
                for (byte b = 0; b <= 100; b++)
                {
                    Thread.Sleep(20);
                }
                // invoke method Save():void to save customer into database
                customer.Save();
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Record inserted successfully!", "Message");

                // return to the previous state of textboxes

                // setting the texts
                txtfName.Text = " First Name";
                txtlName.Text = " Last Name";
                txtContact.Text = " Contact No";
                txtCity.Text = " City";
                txtAddress.Text = " Address";
                txtDestination.Text = " Destination";
                comboCountry.EditValue = "Country";
                comboClass.EditValue = "Class";
                comboDepartureAirport.EditValue = "Departure Airport";
                dateTimePicker1Departure.Value = DateTime.Now;

                // setting the customer picture to null
                customerImg.Image = Properties.Resources.user_male_shape_in_a_circle_ios_7_interface_symbol_318_35357;

                // setting color
                txtfName.ForeColor = Color.Gray;
                txtlName.ForeColor = Color.Gray;
                txtContact.ForeColor = Color.Gray;
                txtCity.ForeColor = Color.Gray;
                txtAddress.ForeColor = Color.Gray;
                txtDestination.ForeColor = Color.Gray;
            }

            else
                MessageBox.Show("Error. Please fill the required fields and try again.","Message Alert");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
