using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dropdownpractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (dropdownlsit1.SelectedValue == "") 
            {
                label1.Text = "please select a city";
            }
            else
            {
                label1.Text = "your choice is " + dropdownlsit1.SelectedValue;
            }
        }
    }
}