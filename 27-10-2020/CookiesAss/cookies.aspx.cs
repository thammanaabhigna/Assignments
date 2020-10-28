using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookiepractice
{
    public partial class withcheckboxes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //setting expiry date and time of the cookie
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "pls select your choice";
            //===adding cookies==============
            if (iphone.Checked)
                Response.Cookies["computer"]["iphone"] = "you have checked for iphone and cookie triggered";
            if (sam.Checked)
                Response.Cookies["computer"]["sam"] = "you have checked for sam and cookie triggered";
            if (leno.Checked)
                Response.Cookies["computer"]["leno"] = "you have checked for leno and cookie triggered";
            if (redmi.Checked)
                Response.Cookies["computer"]["redmi"] = "you have checked for redmi and cookie triggered";
            if (realmi.Checked)
                Response.Cookies["computer"]["realmi"] = "you have checked for realmi and cookie triggered";
            if (nokia.Checked)
                Response.Cookies["computer"]["nokia"] = "you have checked for nokia and cookie triggered";
            if (oppo.Checked)
                Response.Cookies["computer"]["oppo"] = "you have checked for oppo and cookie triggered";
            if (vivo.Checked)
                Response.Cookies["computer"]["vivo"] = "you have checked for vivo and cookie triggered";
            if (oneplus.Checked)
                Response.Cookies["computer"]["oneplus"] = "you have checked for oneplus and cookie triggered";
            if (pixel.Checked)
                Response.Cookies["computer"]["pixel"] = "you have checked for realmi and cookie triggered";
            //fetching code
            if (Request.Cookies["computer"].Values.ToString() != null)
            {
                if (Request.Cookies["computer"]["iphone"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["iphone"] + "" + "";
                if (Request.Cookies["computer"]["sam"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["sam"] + "" + "";
                if (Request.Cookies["computer"]["leno"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["leno"] + "" + "";
                if (Request.Cookies["computer"]["redmi"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["redmi"] + "" + "";
                if (Request.Cookies["computer"]["realme"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["realme"] + "" + "";
                if (Request.Cookies["computer"]["nokia"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["nokia"] + "" + "";
                if (Request.Cookies["computer"]["oppo"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["oppo"] + "" + "";
                if (Request.Cookies["computer"]["vivo"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["vivo"] + "" + "";
                if (Request.Cookies["computer"]["oneplus"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["oneplus"] + "" + "";
                if (Request.Cookies["computer"]["pixcel"] != null)
                    label2.Text = label2.Text + Response.Cookies["computer"]["pixcel"] + "" + "";

            }
            else
            {
                label2.Text = "pls select ur choice";
                
            }
        }
        }
    }
