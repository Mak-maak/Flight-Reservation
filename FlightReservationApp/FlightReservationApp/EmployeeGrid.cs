﻿using System;
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
    public partial class EmployeeGrid : Form
    {
        public EmployeeGrid()
        {
            InitializeComponent();
        }

        private void EmployeeGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fRAppDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.fRAppDataSet1.Employee);

        }
    }
}
