//------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployementManagement.Model;

namespace EmployementManagement.Manager
    {
        /// <summary>
        /// EmployeeManager is a class which interface with IEmployeemanager.
        /// </summary>
        /// <seealso cref="EmployementManagement.Manager.IEmployeeManager" />
        public class EmployeeManager : IEmployeeManager
        {
            private readonly IEmployeeRepo employeeRepository;
            public EmployeeManager()
            {
            }
            public EmployeeManager(IEmployeeRepo employeeManagement)
            {
                employeeRepository = employeeManagement;
            }
            Employee employee = new Employee();
            /// <summary>
            /// Adds the specified identifier.
            /// </summary>
            /// <param name="id">The identifier.</param>
            /// <param name="name">The name.</param>
            /// <param name="city">The city.</param>
            /// <param name="designation">The designation.</param>
            /// <returns></returns>
            public string Add(string id, string name, string city, string designation)
            {
                employee.id = id;
                employee.Name = name;
                employee.City = city;
                employee.Designation = designation;
                employeeRepository.AddEmployee(employee.id, employee.Name, employee.City, employee.Designation);
                return "Added Successfully";
            }
            /// <summary>
            /// Updates the specified identifier.
            /// </summary>
            /// <param name="id">The identifier.</param>
            /// <param name="name">The name.</param>
            /// <param name="city">The city.</param>
            /// <param name="designation">The designation.</param>
            /// <returns></returns>
            public string Update(string id, string name, string city, string designation)
            {
                employee.id = id;
                employee.Name = name;
                employee.City = city;
                employee.Designation = designation;
                try
                {
                    bool result = employeeRepository.UpdateEmployee(employee.id, employee.Name, employee.City, employee.Designation);
                    if (result)
                    {
                        return "update Successfully";
                    }
                    else
                        return "failed";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            /// <summary>
            /// Deletes the specified identifier.
            /// </summary>
            /// <param name="id">The identifier.</param>
            /// <returns></returns>
            public string Delete(string id)
            {
                employee.id = id;
                employeeRepository.DeleteEmployee(employee.id);
                return "Deleted Successfully";
            }
            /// <summary>
            /// Gets this instance.
            /// </summary>
            /// <returns></returns>
            public IEnumerable<Employee> Get()
            {
                return (employeeRepository.GetEmployees().AsEnumerable());
            }

            public string LoginEmployee(string id, string city)
            {
                bool result = employeeRepository.LoginEmployee(id, city);
                if (result)
                {
                var list = this.Get();
                return list.ToString() ;
                }
                else
                    return "failed";

            }
        }
    
}
