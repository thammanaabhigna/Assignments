using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace datatableAss
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Designation");
            dt.Columns.Add("Location");
            dt.Columns.Add("Country");


            dt.Rows.Add("T", "Abhigna", "sf", "chennai", "India");
            dt.Rows.Add("T", "Ramyasree", "sf", "Chennai", "India");
            dt.Rows.Add("B", "Sowmya", "sd", "chennai", "India");
            dt.Rows.Add("R", "Sailesh", "sd", "chennai", "India");
            dt.Rows.Add("M", "Krishna", "HR", "chennai", "India");
            dt.Rows.Add("V", "Shiva krishna", "HR", "Chennai", "India");
            dt.Rows.Add("T", "Aparna", "sd", "Hyderabad", "India");
            dt.Rows.Add("R", "Srinivas", "sf", "hyderabad", "India");
            dt.Rows.Add("T", "Anitha", "manager", "chennai", "India");
            dt.Rows.Add("T", "Venkat", "sf", "Chennai", "India");
            datalist1.DataSource = dt;
            datalist1.DataBind();

        }
    }
}