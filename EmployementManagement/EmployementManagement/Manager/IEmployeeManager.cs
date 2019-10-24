// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------

using EmployementManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployementManagement.Manager
{
    /// <summary>
    /// IEmployeeManager is a Interface
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        string Add(string id, string name, string city, string designation);
        string Update(string id, string name, string city, string designation);
        string Delete(string id);
        string LoginEmployee(string id, string city);
        IEnumerable<Employee> Get();
    }
}
