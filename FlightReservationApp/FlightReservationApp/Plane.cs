using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlightReservationApp
{
    class Plane
    {
        // attributes
        public string PlaneNo { get; set; }
        public string PlaneName { get; set; }
        public string Airline { get; set; }
        public Image Image { get; set; }
        public string PlaneColor { get; set; }

        // method
        public void Save()
        {

            // connection string
            string connectionString = ConfigurationManager.ConnectionStrings["FlightReservation"].ConnectionString;

            // connection string pass to sql connection to access the desired database
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // instantiate sqlCommand to command/query the database
            SqlCommand cmd = new SqlCommand();

            using(MemoryStream ms = new MemoryStream())
            {
                // code to add image to the database

                Image.Save(ms, Image.RawFormat);
                byte[] planeImg = ms.GetBuffer();
                ms.Close();

                // set parameters
                cmd.Connection = sqlConnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@img", planeImg);
                cmd.CommandText = "insert into Plane (planeNo, planeName, airline, img, color) values ('" + PlaneNo + "' , '" + PlaneName + "' , '" + Airline + "' , @img ,'" + PlaneColor + "')";
                
                try
                {
                    // open connection
                    sqlConnection.Open();

                    // execute query
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
