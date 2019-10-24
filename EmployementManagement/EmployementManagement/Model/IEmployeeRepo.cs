// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeRepo.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployementManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IEmployeeRepo
    {
        //<summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployees();
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        bool AddEmployee(string name, string id, string city, string designation);
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        bool UpdateEmployee(string name, string id, string city, string designation);
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(string id);
        /// <summary>
        /// Logins the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        bool LoginEmployee(string id, string city);
    }
}

