using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQueryStrings
{
    public partial class QueryState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {
                Response.Redirect("homepage.aspx?Name=" + TextBox1.Text+ "&pwd" + TextBox2.Text);
                Response.Write("Login successful");
            }
            else
                lblstatus.Text = "Invalid user,login failed";
        }

        
    }
}