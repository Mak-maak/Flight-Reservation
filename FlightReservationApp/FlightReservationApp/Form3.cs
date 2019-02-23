using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            // instantiate InsPlane
            InsPlane planeForm = new InsPlane();
            planeForm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // instantiate InsEmployee
            InsEmployee empForm = new InsEmployee();
            empForm.Show();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            // instantiate plane grid
            PlaneGrid pg = new PlaneGrid();
            pg.Show();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            // instantiate employee grid
            EmployeeGrid eg = new EmployeeGrid();
            eg.Show();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            // instantiate flight grid
            FlightGrid fg = new FlightGrid();
            fg.Show();
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            // instantiate customer grid
            CustomerGrid cg = new CustomerGrid();
            cg.Show();
        }
    }
}
