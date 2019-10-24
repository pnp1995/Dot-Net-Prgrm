// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployementManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// public class for employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public string id
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Display(Name = "Name")]
        public string Name
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [Display(Name = "City")]
        public string City
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        /// <value>
        /// The designation.
        /// </value>
        [Display(Name = "Designation")]
        public string Designation
        {
            get; set;
        }
    }
}
