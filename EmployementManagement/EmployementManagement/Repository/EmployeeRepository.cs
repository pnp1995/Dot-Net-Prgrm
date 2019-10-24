// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployementManagement.Repositry
{
    using EmployementManagement.Model;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    public class EmployeeRepository : IEmployeeRepo
    {
        /// <summary>
        /// The connect
        /// </summary>
        private SqlConnection connect = null;
        private readonly IConfiguration configurations;
        string Connectstr = null;
        public EmployeeRepository()
        {

        }
        public EmployeeRepository(IConfiguration configuration)
        {
            configurations = configuration;
        }
        //// To Handle connection related activities
        public void Connection()
        {
            try
            {
                Connectstr = configurations.GetSection("ConnectionString").GetSection("UserDBConncetion").Value;
                connect = new SqlConnection(Connectstr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        public bool AddEmployee(string id, string name, string city, string designation)
        {
            Connection();
            SqlCommand command = new SqlCommand("AddEmployee", connect);
            Employee employee = new Employee();
            employee.id = id;
            employee.Name = name;
            employee.City = city;
            employee.Designation = designation;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", employee.id);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@City", employee.City);
            command.Parameters.AddWithValue("@Designation", employee.Designation);
            connect.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>

        //To Update Employee details
        public bool UpdateEmployee(string id, string name, string city, string designation)
        {
            Connection();
            SqlCommand command = new SqlCommand("UpdateEmployee", connect);
            Employee employee = new Employee();
            employee.id = id;
            employee.Name = name;
            employee.City = city;
            employee.Designation = designation;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", employee.id);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@City", employee.City);
            command.Parameters.AddWithValue("@Designation", employee.Designation);
            connect.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>

        //To Delete Employee details
        public bool DeleteEmployee(string id)
        {
            Connection();
            SqlCommand command = new SqlCommand("DeleteEmployee", connect);
            Employee employee = new Employee();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            connect.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            Connection();
             List<Employee> employees = new List<Employee>();
            SqlCommand command = new SqlCommand("viewEmployee", connect);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connect.Open();
            adapter.Fill(dataTable);
            connect.Close();
            employees = (from DataRow data in dataTable.Rows
                         select new Employee()
                         {
                             id = Convert.ToString(data["id"]),
                             Name = Convert.ToString(data["name"]),
                             City = Convert.ToString(data["city"]),
                             Designation = Convert.ToString(data["designation"])
                         }
                         ).ToList();
            return employees;
        }

        public bool LoginEmployee(string id, string city)
        {
            Connection();
            SqlCommand command = new SqlCommand("loginemployee", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@city", city);
            connect.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);
            connect.Close();

            bool LoginEmployeeSuccessfully = ((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows.Count > 0));

            if (LoginEmployeeSuccessfully && id != "" && city != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
