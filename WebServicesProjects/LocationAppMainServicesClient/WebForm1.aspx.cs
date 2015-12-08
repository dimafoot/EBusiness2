using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LocationAppMainServicesClient.ServiceReference1;

namespace LocationAppMainServicesClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();

            lblResult.Text =  client.Add(Convert.ToInt16(txtFirstNumber.Text), Convert.ToInt16(txtSecondNumber.Text)).ToString();

            gvCalculations.DataSource = client.GetCalculations();
            gvCalculations.DataBind();

        }
    }
}