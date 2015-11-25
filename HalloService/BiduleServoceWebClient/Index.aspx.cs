using BiduleServoceWebClient.ServiceReference;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;

namespace BiduleServoceWebClient
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddlEmployeeType.SelectedValue == "-1")
            //{
            //    trAnnualSalary.Visible = false;
            //    trHourlyPay.Visible = false;
            //    trHoursworked.Visible = false;
            //}
            //else if (ddlEmployeeType.SelectedValue == "1")
            //{
            //    trAnnualSalary.Visible = true;
            //    trHourlyPay.Visible = false;
            //    trHoursworked.Visible = false;
            //}
            //else
            //{
            //    trAnnualSalary.Visible = false;
            //    trHourlyPay.Visible = true;
            //    trHoursworked.Visible = true;
            //}
        }


        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            IBiduleService client = new BiduleServiceClient();
            //IEmployeeService client = new EmployeeServiceClient();

            //Employee employee = client.GetFullTimeEmployee();

            //txtID.Text = employee.Id.ToString();
            //txtName.Text = employee.Name;
            //txtGender.Text = employee.Gender;
            //txtDateofb.Text = employee.Dateofb.ToShortDateString();
            //txtAnnualSalary.Text = ((FullTimeEmployee)employee).AnnualSalary.ToString();
        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                IBiduleService client = new BiduleServiceClient();
                //IEmployeeService client = new EmployeeServiceClient();
                Employee employee = new Employee();

                if ((EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue) == EmployeeType.FullTimeEmployee)
                {
                    employee = new FullTimeEmployee
                    {
                        Id = Convert.ToInt32(txtID.Text),
                        Name = txtName.Text,
                        Gender = txtGender.Text,
                        Dateofb = Convert.ToDateTime(txtDateofb.Text),
                        Type = EmployeeType.FullTimeEmployee,
                        AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text)
                    };

                    client.SaveEmployee(employee);
                    LblMessage.Text = "Full time employee saved";
                }
                else if ((EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue) == EmployeeType.PartTimeEmployee)
                {
                    employee = new PartTimeEmployee
                    {
                        Id = Convert.ToInt32(txtID.Text),
                        Name = txtName.Text,
                        Gender = txtGender.Text,
                        Dateofb = Convert.ToDateTime(txtDateofb.Text),
                        Type = EmployeeType.PartTimeEmployee,
                        HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
                        HoursWorked = Convert.ToInt32(txtHoursworked.Text)
                    };

                    client.SaveEmployee(employee);
                    LblMessage.Text = "Part time employee saved";
                }
                else
                {
                    LblMessage.Text = "Please select Employee type";
                }


            }
            catch (FaultException faultException)
            {
                LblMessage.Text = faultException.Message;
            }
        }

        protected void btnGetEmployeeDB_Click(object sender, EventArgs e)
        {
            ////try
            ////{

            try
            {

                IBiduleService client0 = new BiduleServiceClient() ;

                ClientEmployee employee = client0.GetEmployeeClient();



                ////IBiduleService client = new BiduleServiceClient();
                ////Employee employee0 = client.GetEmployeeDB(Convert.ToInt32(txtID.Text));

                txtName.Text = employee.Name;
                txtGender.Text = employee.Gender;
                txtDateofb.Text = employee.Dateofb.ToShortDateString();

                if (employee.Type == EmployeeClientType.FullTimeClientEmployee)
                {
                    txtAnnualSalary.Text = ((FullTimeClientEmployee)employee).AnnualSalary.ToString();
                    txtAnnualSalary.Visible = true;
                    txtHourlyPay.Visible = false;
                    txtHoursworked.Visible = false;
                }


                //if (employee.Type == EmployeeType.FullTimeEmployee)
                //{
                //    txtAnnualSalary.Text = ((FullTimeEmployee)employee).AnnualSalary.ToString();
                //    txtAnnualSalary.Visible = true;
                //    txtHourlyPay.Visible = false;
                //    txtHoursworked.Visible = false;

                //}
                //else
                //{
                //    txtHourlyPay.Text = ((PartTimeEmployee)employee).HourlyPay.ToString();
                //    txtHoursworked.Text = ((PartTimeEmployee)employee).HoursWorked.ToString();
                //    txtAnnualSalary.Visible = false;
                //    txtHourlyPay.Visible = true;
                //    txtHoursworked.Visible = true;

                //}

                ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();

                LblMessage.Text = "Employee retrieved";
            }
            catch (FaultException faultException)
            {
                Debug.Write("Get Employee Service :" + faultException.Message);
                LblMessage.Text = faultException.Message;
            }
            catch (FormatException formatException)
            {
                Debug.Write("Get Employee Service :" + formatException.Message);
                LblMessage.Text = formatException.Message;
            }


            ////}
            ////catch (FaultException<ZeroFault> faultException)
            ////{
            ////    Debug.Write("Get Employee Service :" + faultException.Message);
            ////    LblMessage.Text = faultException.Detail.Error + " - "+ faultException.Detail.Details;
            ////}
            ////catch (FormatException formatException)
            ////{
            ////    Debug.Write("Get Employee Service :" + formatException.Message);
            ////    LblMessage.Text = formatException.Message;
            ////}



            if (ddlEmployeeType.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = false;
                trHoursworked.Visible = false;
            }
            else if (ddlEmployeeType.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlyPay.Visible = false;
                trHoursworked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = true;
                trHoursworked.Visible = true;
            }
        }

        protected void ddlEmployeeType_TextChanged(object sender, EventArgs e)
        {
            if (ddlEmployeeType.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = false;
                trHoursworked.Visible = false;
            }
            else if (ddlEmployeeType.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlyPay.Visible = false;
                trHoursworked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = true;
                trHoursworked.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IBiduleService client = new BiduleServiceClient();
            Label1.Text = client.GetMessage(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            IBiduleService client = new BiduleServiceClient();

            IEnumerable clients = client.GetClients().Where(clt => clt.Id > 1);

            GridView1.DataSource = clients;
            GridView1.DataBind();
        }

    }
}