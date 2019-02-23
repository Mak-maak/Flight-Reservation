using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace FlightReservationApp
{
    class Customer
    {
        // attributes
        public string CustomerName { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Image Image { get; set; }

        // methods
        public void Save()
        {

            // connection string
            string connectionString = ConfigurationManager.ConnectionStrings["FlightReservation"].ConnectionString;

            // connection string pass to sql connection to access the desired database
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // instantiate sqlCommand to command/query the database
            SqlCommand cmd = new SqlCommand();

            using (MemoryStream ms = new MemoryStream())
            {
                // code to add image to the database

                Image.Save(ms, Image.RawFormat);
                byte[] customerImg = ms.GetBuffer();
                ms.Close();

                // set parameters
                cmd.Connection = sqlConnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@img", customerImg);
                cmd.CommandText = "insert into Customer (customerName, contactNo, gender, country, city, adress, img) values ('" + CustomerName + "' , '" + ContactNo + "' , '" + Gender + "' ,'"+Country+"','"+City+"','"+Address+"', @img)";

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