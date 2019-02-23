using DevExpress.XtraSplashScreen;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // instantiate placeholder
        PlaceHolderText placeholder = new PlaceHolderText();

        // OnFocus event for user name
        private void txtUserNameGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtUserName = (TextBox)sender;
            placeholder.OnFocus(txtUserName, " User Name");
        }

        // LostFocus event for user name
        private void txtUserNameLostFocus_Click(object sender, EventArgs e)
        {
            TextBox txtUserName = (TextBox)sender;
            placeholder.LoseFocus(txtUserName, " User Name");

        }

        // OnFocus event for password
        private void txtPasswordGotFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPassword = (TextBox)sender;
            txtPassword.UseSystemPasswordChar = true;
            placeholder.OnFocus(txtPassword, " Password");
        }

        // LoseFocus event for password
        private void txtPasswordLoseFocus_Click(object sender, EventArgs e)
        {
            TextBox txtPassword = (TextBox)sender;
            txtPassword.UseSystemPasswordChar = true;
            placeholder.LoseFocus(txtPassword, " Password", "password");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToLower() == "client" && txtPassword.Text == "123")
            {
                splashScreenManager2.ShowWaitForm();
                for (byte b = 0; b<=100; b++)
                {
                    //waiting : each iteration will occur in 0.1 second
                    Thread.Sleep(30);
                }

                // instantiate form 2 to proceed to
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();

                // close the waiting form
                splashScreenManager2.CloseWaitForm();
         }
            else if (txtUserName.Text.ToLower() == "admin" && txtPassword.Text == "admin")
            {
                splashScreenManager2.ShowWaitForm();
                for (byte b = 0; b<=100; b++)
                {
                    //waiting : each iteration will occur in 0.1 second
                    Thread.Sleep(30);
                }

                // instantiate form 2 to proceed to
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();                

                // close the waiting form
                splashScreenManager2.CloseWaitForm();
            }
            else MessageBox.Show("Invalid User Name or Password!\nPlease try again!","Alert");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (byte b = 0; b<=100; b++)
            {
                // mapping progress
                Thread.Sleep(100);
            }
            // userName events
            txtUserName.GotFocus += new EventHandler(this.txtUserNameGotFocus_Click);
            txtUserName.LostFocus += new EventHandler(this.txtUserNameLostFocus_Click);

            // password events
            txtPassword.GotFocus += new EventHandler(this.txtPasswordGotFocus_Click);
            txtPassword.LostFocus += new EventHandler(this.txtPasswordLoseFocus_Click);
        }
    }
}
