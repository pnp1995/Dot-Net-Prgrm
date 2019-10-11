// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Details.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Pattern.PrototypeDesign
{
    class Details
    {
        public void ManagerDetails()
        {
            //// Enter the first Manager Details
            Console.WriteLine("Company Name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter the first managerName");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter " + FirstName + " EmployeeId");
            int FirstId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + FirstName + " Salary");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + FirstName + " Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter " + FirstName + " StreetNumber");
            int StreetNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + FirstName + " State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter " + FirstName + " ZipNumber");
            int ZipNumber = Convert.ToInt32(Console.ReadLine());

            //// Enter the Second Manager Details.
            Console.WriteLine("Enter the Second managerName");
            string SecondName = Console.ReadLine();
            Console.WriteLine("Enter " + SecondName + " EmployeeId");
            int firstId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + SecondName + " Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + SecondName + " Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter " + SecondName + " StreetNumber");
            int streetNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + SecondName + " State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter " + SecondName + " ZipNumber");
            int zipNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CompanyName\tEmployeeName\tEmployeeId\tSalary\tAddress\tStreetNumber\tState\tZipNumber");

            //// Creating Manager Object as manager for first manager.
            Manager manager = new Manager();
            manager.CompanyName = companyName;
            manager.EmployeeName = FirstName;
            manager.EmployeeId = FirstId;
            manager.Salary = Salary;
            manager.Address = Address;
            manager.StreetNumber = StreetNumber;
            manager.State = State;
            manager.ZipNumber = ZipNumber;

            //// Creating Manager Object as managerCopy for Second manager.
            //// By using .Clone() it copy manager object to managerCopy for Second manager.
            Manager managerCopy = (Manager)manager.Clone();
            managerCopy.EmployeeName = FirstName;
            managerCopy.EmployeeId = firstId;
            managerCopy.Salary = salary;
            managerCopy.Address = address;
            managerCopy.StreetNumber = streetNumber;
            managerCopy.State = state;
            managerCopy.ZipNumber = zipNumber;
            Console.WriteLine(manager.GetDetails());
            Console.WriteLine(managerCopy.GetDetails());

        }
        public void OperatorEmployee()
        {
            //// Enter the first operator employee details.
            Console.WriteLine("Enter Company Name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter the first Employee Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter " + FirstName + " EmployeeId");
            int firstId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + FirstName + " Salary");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + FirstName + " Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter " + FirstName + " StreetNumber");
            int StreetNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + FirstName + " State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter " + FirstName + " ZipNumber");
            int ZipNumber = Convert.ToInt32(Console.ReadLine());

            //// Enter the second operator employee details.
            Console.WriteLine("Enter the Second Employee Name");
            string SecondName = Console.ReadLine();
            Console.WriteLine("Enter " + SecondName + " EmployeeId");
            int FirstId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + SecondName + " Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + SecondName + " Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter " + SecondName + " StreetNumber");
            int streetNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + SecondName + " State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter " + SecondName + " ZipNumber");
            int zipNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CompanyName\tEmployeeName\tEmployeeId\tSalary\tAddress\tStreetNumber\tState\tZipNumber");
           
            //// Creating Operaor Object as operator for first Employee.
            Operator operatorObject = new Operator();
            operatorObject.CompanyName = companyName;
            operatorObject.EmployeeName = FirstName;
            operatorObject.EmployeeId = FirstId;
            operatorObject.Salary = Salary;
            operatorObject.Address = Address;
            operatorObject.StreetNumber = StreetNumber;
            operatorObject.State = State;
            operatorObject.ZipNumber = ZipNumber;

            //// Creating Operator Object as operatorobjectCopy for Second employee.
            //// By using .Clone() it copy operator object to operatorobject Copy for Second employee.
            Operator operatorObjectCopy = (Operator)operatorObject.Clone();
            operatorObjectCopy.EmployeeName = FirstName;
            operatorObjectCopy.EmployeeId = firstId;
            operatorObjectCopy.Salary = salary;
            operatorObjectCopy.Address = address;
            operatorObjectCopy.StreetNumber = streetNumber;
            operatorObjectCopy.State = state;
            operatorObjectCopy.ZipNumber = zipNumber;
            Console.WriteLine(operatorObject.GetDetails());
            Console.WriteLine(operatorObjectCopy.GetDetails());
        }
    }
}
