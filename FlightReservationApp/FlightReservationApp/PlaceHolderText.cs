using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationApp
{
    class PlaceHolderText
    {
        string clear = "";

        public void OnFocus(TextBox textbox, string placeholderText)
        {
            if (textbox.Text == placeholderText)
            {
                textbox.Text = clear;
                textbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        // LoseFocus
        public void LoseFocus(TextBox textbox, string placeholderText)
        {
            if (textbox.Text == clear)
            {
                textbox.Text = placeholderText;
                textbox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        public void LoseFocus(TextBox textbox, string placeholderText, string type)
        {
            if (textbox.Text == clear && type == "password")
            {
                textbox.UseSystemPasswordChar = false;
                textbox.Text = placeholderText;
                textbox.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
