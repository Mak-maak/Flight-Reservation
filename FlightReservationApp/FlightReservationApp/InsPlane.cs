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
    public partial class InsPlane : Form
    {
        public InsPlane()
        {
            InitializeComponent();
        }

        private void InsPlane_Load(object sender, EventArgs e)
        {
            // firstName events
            txtPlaneNo.GotFocus += new EventHandler(this.txtPlaneNoGotFocus_Click);
            txtPlaneNo.LostFocus += new EventHandler(this.txtPlaneNoLoseFocus_Click);

            // lastName events
            txtAirline.GotFocus += new EventHandler(this.txtAirlineGotFocus_Click);
            txtAirline.LostFocus += new EventHandler(this.txtAirlineLoseFocus_Click);

            // contact events
            txtPlaneName.GotFocus += new EventHandler(this.txtPlaneNameGotFocus_Click);
            txtPlaneName.LostFocus += new EventHandler(this.txtPlaneNameLoseFocus_Click);

            // color events
            txtPlaneColor.GotFocus += new EventHandler(this.txtPlaneColorGotFocus_Click);
            txtPlaneColor.LostFocus += new EventHandler(this.txtPlaneColorLoseFocus_Click);
        }

        // instantiate place holder class
        PlaceHolderText ph = new PlaceHolderText();

        // got focus event for firstName
        private void txtPlaneNameGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPlaneName = (TextBox)sender;
            ph.OnFocus(txtPlaneName, " Plane Name");
        }


        // lose focus event for firstName
        private void txtPlaneNameLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPlaneName = (TextBox)sender;
            ph.LoseFocus(txtPlaneName, " Plane Name");
        }

        // got focus event for last name
        private void txtPlaneNoGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPlaneNo = (TextBox)sender;
            ph.OnFocus(txtPlaneNo, " Plane No");
        }

        // lose focus event for lastName
        private void txtPlaneNoLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPlaneNo = (TextBox)sender;
            ph.LoseFocus(txtPlaneNo, " Plane No");
        }

        // got focus event for contact
        private void txtAirlineGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtAirline = (TextBox)sender;
            ph.OnFocus(txtAirline, " Airline");
        }

        // lose focus event for contact
        private void txtAirlineLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtAirline = (TextBox)sender;
            ph.LoseFocus(txtAirline, " Airline");
        }

        // got focus event for firstName
        private void txtPlaneColorGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPlaneColor = (TextBox)sender;
            ph.OnFocus(txtPlaneColor, " Plane Color");
        }


        // lose focus event for firstName
        private void txtPlaneColorLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPlaneColor = (TextBox)sender;
            ph.LoseFocus(txtPlaneColor, " Plane Color");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                planeImg.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSavePlane_Click(object sender, EventArgs e)
        {
            if (txtAirline.Text != null && txtAirline.Text != " Airline" &&
                txtPlaneName.Text != null && txtPlaneName.Text != " Plane Name" &&
                txtPlaneNo.Text != null && txtPlaneNo.Text != " Plane No" &&
                txtPlaneColor.Text != null && txtPlaneColor.Text != " Plane Color"
                ) {

                // instantiate plane class
                Plane plane = new Plane();

                // data binding
                plane.PlaneNo = txtPlaneNo.Text;
                plane.PlaneName = txtPlaneName.Text;
                plane.Airline = txtAirline.Text;
                plane.PlaneColor = txtPlaneColor.Text;
                plane.Image = planeImg.Image;


                // show wait form
                splashScreenManager1.ShowWaitForm();

                // add loop to display wait form until transaction get done
                for (byte b = 0; b <= 100; b++)
                {
                    Thread.Sleep(20);
                }

                // save plane into database
                plane.Save();

                // close the waiting form
                splashScreenManager1.CloseWaitForm();


                // get back to their previous text
                txtPlaneNo.Text = " Plane No";
                txtPlaneName.Text = " Plane Name";
                txtAirline.Text = " Airline";
                txtPlaneColor.Text = " Plane Color";

                // set their colors again to gray
                txtPlaneNo.ForeColor = Color.Gray;
                txtPlaneName.ForeColor = Color.Gray;
                txtPlaneColor.ForeColor = Color.Gray;
                txtAirline.ForeColor = Color.Gray;

                MessageBox.Show("Record inserted successfully!", "Messgae");
            }

            else
                MessageBox.Show("Error. Please fill the required fields and try again.","Message Alert");
        }
    }
}
