using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebRipGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When there is a URL in txtboxURL, create HTML Request, Stream, and Stream reader.
            //Else, popup that says "Please insert valid URL"

            if (txtboxURL.Text != "")
            {
                //Check if valid URL (starts with http:// or https://)
                if (HTTPConnect.isValidURL(txtboxURL.Text.ToString()) == true)     //Success
                {
                    //MessageBox.Show("Success, valid URL", "Success");
                    txtboxHTML.Text = HTTPConnect.GetHTML(txtboxURL.Text.ToString());
                }
                else    //No Valid URL
                {
                    MessageBox.Show("Please insert a valid URL", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please insert a valid URL", "Error");

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
