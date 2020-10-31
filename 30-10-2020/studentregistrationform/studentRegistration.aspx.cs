using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace studentadmissions
{
    public partial class Registrationform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click1(object sender, EventArgs e)
        //{
        //    if (CheckBox7.Checked)
        //        Label2.Text = "you have checked " + CheckBox7.Text + "<br> ";
        //    if (CheckBox8.Checked)
        //        Label2.Text = Label1.Text + " you have checked " + CheckBox8.Text + "<br> ";
        //    if (CheckBox9.Checked)
        //        Label2.Text = Label1.Text + " you have checked " + CheckBox9.Text + "<br> ";

            
        //    //Label1.Text = "Registration successful.Thank you!";
        //}

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox7.Checked)
                Label2.Text = "selected course " + CheckBox7.Text + "<br> ";
            if (CheckBox8.Checked)
                Label2.Text = Label1.Text + " selected course " + CheckBox8.Text + "<br> ";
            if (CheckBox9.Checked)
                Label2.Text = Label1.Text + " selected course" + CheckBox9.Text + "<br> ";


        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox10.Checked)
                Label2.Text = Label2.Text + " selected course " + CheckBox10.Text + "<br> ";
            if (CheckBox11.Checked)
                Label2.Text = Label2.Text + " selected course " + CheckBox11.Text + "<br> ";
            if (CheckBox12.Checked)
                Label2.Text = Label2.Text + " selected course " + CheckBox12.Text + "<br> ";



            
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Write("congrats!registration successfull!");
            
        }
    }
}
    
   