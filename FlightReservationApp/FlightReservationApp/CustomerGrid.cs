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
    public partial class CustomerGrid : Form
    {
        public CustomerGrid()
        {
            InitializeComponent();
        }

        private void CustomerGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fRAppDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.fRAppDataSet3.Customer);

        }
    }
}
