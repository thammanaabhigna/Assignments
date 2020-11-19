using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString_Assignment
{
    public partial class QueryString1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" && TextBox2.Text == "" &&
                TextBox3.Text == "" && TextBox4.Text == "" && TextBox5.Text == "")
                
            {
                Response.Redirect("Homepage.aspx?Name=" + TextBox1.Text + "&Email=" + TextBox2.Text+
                    "&DateOfRegistration=" +TextBox3.Text + "&Department=" + TextBox4.Text+ "&Aggregate"+TextBox5.Text);
                Response.Write("Login Successful");
            }

        }

        
    }
}