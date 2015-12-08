using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServiceWebClientProject.ServiceReference1;

namespace WebServiceWebClientProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeWebServiceSoap client = new EmployeeWebServiceSoapClient();
            int result =  client.GetRadomNumber();
            TextBox1.Text = result.ToString();

            //client.GetRandoms();
            //gvRandoms.DataBind();
        }
    }
}