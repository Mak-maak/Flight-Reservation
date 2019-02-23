using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationApp
{
    class Employee
    {
        // attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Image Image { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

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
                byte[] empImg = ms.GetBuffer();
                ms.Close();

                // set parameters
                cmd.Connection = sqlConnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@img", empImg);
                cmd.CommandText = "insert into Employee (empFirstName, empLastName, empContact, country, city, adress, department, jobTitle, salary, img, gender) values ('" + FirstName + "' ,'" + LastName + "' , '" + ContactNo + "' , '" + Country + "' ,'" + City + "','" + Address + "', '"+ Department + "' , '" + JobTitle + "', '" + Salary + "',  @img ,'"+ Gender +"')";

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
