using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LocationAppMainServicesClient.ServiceReference1;

namespace LocationAppMainServicesClient
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceReference1.ITrainServices client2 = new TrainServicesClient();

            gvCalculations.DataSource = client2.GetCalculations();
            gvCalculations.DataBind();
        }
    }
}