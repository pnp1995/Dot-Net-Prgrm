// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployementManagement.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployementManagement.Manager;
    using EmployementManagement.Model;
    using EmployementManagement.Repositry;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    //[Route("api/[controller]")]
    //[ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository empRepo = new EmployeeRepository();
        private readonly IEmployeeManager employeeManager;
        public EmployeeController(IEmployeeManager employee)
        {
            employeeManager = employee;
        }
        [HttpGet]
        [Route("get")]
        public IActionResult ListOfEmployees()
        {
            try
            {
                return Ok(employeeManager.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddEmployee(Employee employee)
        {
            try
            {

                var result = employeeManager.Add(employee.id, employee.Name, employee.City, employee.Designation);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // PUT: Employee/UpdateEmpDetails. 
        [HttpPut]
        [Route("Update")]
        public IActionResult UpdateEmployee(string id, string name, string city, string designation)
        {
            try
            {
                var result = employeeManager.Update(id, name, city, designation);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteEmployee(string id)
        {
            try
            {
                var result = employeeManager.Delete(id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult LoginEmployee(string id, string city)
        {
            try
            {
                var result = employeeManager.LoginEmployee(id, city);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
