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
    public partial class FlightGrid : Form
    {
        public FlightGrid()
        {
            InitializeComponent();
        }

        private void FlightGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fRAppDataSet2.Flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.fRAppDataSet2.Flight);

        }
    }
}
