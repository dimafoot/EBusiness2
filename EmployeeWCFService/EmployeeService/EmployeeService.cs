using System;
using System.Collections.Generic;
using EmployeeService.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Loguer;

namespace EmployeeService
{
    //[GlobalErrorHandlerBehavior(typeof(GlobalErrorHandler))]
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAllEmployees()
        {
            try
            {
                List<Employee> listEmployees = new List<Employee>();

                LogDeb.LogException("EmployeeService", "GetAllEmployees", "GetAllEmployees Debut Ok");
                //Employee employee = new Employee();
                Employee employee = null;

                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if ((EmployeeType)reader["EmployeeType"] == EmployeeType.FullTimeEmployee)
                        {
                            employee = new FullTimeEmployee
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Dateofb = Convert.ToDateTime(reader["Dateofb"]),
                                AnnualSalary = Convert.ToInt32(reader["AnnualSalary"]),
                                Type = EmployeeType.FullTimeEmployee
                            };
                            listEmployees.Add(employee);
                        }
                        else
                        {
                            employee = new PartTimeEmployee
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Dateofb = Convert.ToDateTime(reader["Dateofb"]),
                                HourlyPay = Convert.ToInt32(reader["HourlyPay"]),
                                HoursWorked = Convert.ToInt32(reader["HoursWorked"]),
                                Type = EmployeeType.PartTimeEmployee
                            };
                            listEmployees.Add(employee);
                        }
                    }
                }
                LogDeb.LogException("EmployeeService", "GetAllEmployees", "GetAllEmployees End Ok");

                return listEmployees;
            }
            catch (Exception ex)
            {
                LogDeb.LogException("EmployeeService", "GetEmployee", "Error :" + ex.Message);
                throw ex;
            }


        }

        public List<Employee> GetAllEmployeesDummy()
        {
            try
            {
                List<Employee> listEmployees = new List<Employee>();

                LogDeb.LogException("EmployeeService", "GetAllEmployees", "GetAllEmployees Debut Ok");

                Employee employee = null;


                employee = new FullTimeEmployee
                            {
                                Id = 1,
                                Name = "Name Dummy 1",
                                Gender = "M",
                                Dateofb = Convert.ToDateTime("21/10/1990"),
                                AnnualSalary = 35000,
                                Type = EmployeeType.FullTimeEmployee
                            };
                            listEmployees.Add(employee);
                 
                 employee = new PartTimeEmployee
                            {
                                 Id = 2,
                                 Name = "Name Dummy 2",
                                 Gender = "M",
                                 Dateofb = Convert.ToDateTime("21/10/1990"),
                                 HourlyPay = 150,
                                 HoursWorked = 2500,
                                 Type = EmployeeType.PartTimeEmployee
                            };
                            listEmployees.Add(employee);


                LogDeb.LogException("EmployeeService", "GetAllEmployees", "GetAllEmployees End Ok");

                return listEmployees;
            }
            catch (Exception ex)
            {
                LogDeb.LogException("EmployeeService", "GetEmployee", "Error :" + ex.Message);
                throw ex;
            }
        }

        public Employee GetEmployeeDB(int Id)
        {
            try
            {

                //if (Id == 0)
                //    throw new FaultException("Id égal a zero",new FaultCode("IdIsEqualToZero"));

                LogDeb.LogException("EmployeeService", "GetEmployee", "GetEmployee Debut Ok");
                //Employee employee = new Employee();
                Employee employee = null;

                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "@Id";
                    parameterId.Value = Id;
                    cmd.Parameters.Add(parameterId);
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if ((EmployeeType)reader["EmployeeType"] == EmployeeType.FullTimeEmployee)
                        {
                            employee = new FullTimeEmployee
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Dateofb = Convert.ToDateTime(reader["Dateofb"]),
                                AnnualSalary = Convert.ToInt32(reader["AnnualSalary"]),
                                Type = EmployeeType.FullTimeEmployee
                            };
                        }
                        else
                        {
                            employee = new PartTimeEmployee
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Dateofb = Convert.ToDateTime(reader["Dateofb"]),
                                HourlyPay = Convert.ToInt32(reader["HourlyPay"]),
                                HoursWorked = Convert.ToInt32(reader["HoursWorked"]),
                                Type = EmployeeType.PartTimeEmployee
                            };
                        }
                    }
                }
                LogDeb.LogException("EmployeeService", "GetEmployee", "Employee : " + employee.Id + " - " + employee.Name + " - " + employee.Type + " ");
                LogDeb.LogException("EmployeeService", "GetEmployee", "GetEmployee End Ok");
                return employee;
            }
            catch (Exception ex)
            {
                LogDeb.LogException("EmployeeService", "GetEmployee", "Error :" + ex.Message);
                throw ex;
            }
            ////    throw new FaultException<ZeroFault>(zeroException);
            ////    //return null;
            ////}


            //catch (FaultException faultException)
            //{
            //    LogDeb.LogException("EmployeeService", "GetEmployee", faultException.Message);
            //    return null;
            //}

        }

        public Employee GetEmployeeDBDummy(int Id)
        {
            try
            {
                LogDeb.LogException("EmployeeService", "GetEmployeeDBDummy", "GetEmployee Debut Ok");
                Employee employee = null;

                //employee = new FullTimeEmployee
                //            {
                //                Id = 2,
                //                Name = "Name Dummy 2",
                //                Gender = "M",
                //                Dateofb = Convert.ToDateTime("21/10/1988"),
                //                AnnualSalary = 1900,
                //                Type = EmployeeType.FullTimeEmployee
                //            };

                 employee = new PartTimeEmployee
                            {
                                Id = 1,
                                Name = "Name Dummy 1",
                                Gender = "M",
                                Dateofb = Convert.ToDateTime("21/10/1988"),
                                HourlyPay = 15,
                                HoursWorked = 2500,
                                Type = EmployeeType.PartTimeEmployee
                            };

                LogDeb.LogException("EmployeeService", "GetEmployee", "Employee : " + employee.Id + " - " + employee.Name + " - " + employee.Type + " ");
                LogDeb.LogException("EmployeeService", "GetEmployee", "GetEmployee End Ok");
                return employee;
            }
            catch (Exception ex)
            {
                LogDeb.LogException("EmployeeService", "GetEmployee", "Error :" + ex.Message);
                throw ex;
            }
        }

        public void SaveEmployee(Employee Employee)
        {
            LogDeb.LogException("EmployeeService", "SaveEmployee", "SaveEmployee Debut Ok");

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter()
                {
                    ParameterName = "@Id",
                    Value = Employee.Id
                };

                cmd.Parameters.Add(parameterId);

                SqlParameter parameterName = new SqlParameter()
                {
                    ParameterName = "@Name",
                    Value = Employee.Name
                };
                cmd.Parameters.Add(parameterName);

                SqlParameter parameterGender = new SqlParameter()
                {
                    ParameterName = "@Gender",
                    Value = Employee.Gender
                };
                cmd.Parameters.Add(parameterGender);

                SqlParameter parameterDateofb = new SqlParameter()
                {
                    ParameterName = "@Dateofb",
                    Value = Employee.Dateofb
                };
                cmd.Parameters.Add(parameterDateofb);

                SqlParameter parameterEmployeeType = new SqlParameter()
                {
                    ParameterName = "@EmployeeType",
                    Value = Employee.Type
                };
                cmd.Parameters.Add(parameterEmployeeType);

                if (Employee.GetType() == typeof(FullTimeEmployee))
                {
                    SqlParameter parameterAnnualSalary = new SqlParameter()
                    {
                        ParameterName = "@AnnualSalary",
                        Value = ((FullTimeEmployee)Employee).AnnualSalary
                    };
                    cmd.Parameters.Add(parameterAnnualSalary);
                }
                else
                {
                    SqlParameter parameterHourlyPay = new SqlParameter
                    {
                        ParameterName = "@HourlyPay",
                        Value = ((PartTimeEmployee)Employee).HourlyPay
                    };
                    cmd.Parameters.Add(parameterHourlyPay);

                    SqlParameter parameterHoursWorked = new SqlParameter
                    {
                        ParameterName = "@HoursWorked",
                        Value = ((PartTimeEmployee)Employee).HoursWorked
                    };
                    cmd.Parameters.Add(parameterHoursWorked);
                }

                con.Open();
                cmd.ExecuteNonQuery();
                LogDeb.LogException("EmployeeService", "SaveEmployee", "SaveEmployee End Ok");

            }
        }

    }
}
