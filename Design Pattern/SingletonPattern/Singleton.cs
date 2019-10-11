// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Singlton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Design_Pattern.SingletonPattern
{
    /// <summary>
    /// A Singleton Class.
    /// </summary>
    public class Singleton
    {
        public static void SingletonOperation()
        {
            try
            {
                Console.WriteLine("Eager Initialization");
                //// Provide support for  parellel loop and regions and we have created two method by using parellel and invoke action. 
                Parallel.Invoke(() => StudentDetails(), () => SchoolDetails());
                Console.WriteLine("\nLazy Initialization");
                Parallel.Invoke(() => EmployeeDetails(), () => CompanyDetails());
                Console.WriteLine("\nThreadSafe Singleton");
                Parallel.Invoke(() => ManagerDetails(), () => HrDetails());
                Console.WriteLine("\nBillPugh Singleton");
                Parallel.Invoke(() => FactoryDetails(), () => IndustryDetails());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Students the details.
        /// </summary>
        public static void StudentDetails()
            {
                try
                {
                    EagerInitialization student = EagerInitialization.GetInstance;
                    student.PrintDetails("Student");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        /// <summary>
        /// Schools the details.
        /// </summary>
        public static void SchoolDetails()
        {
            try
            {
                EagerInitialization school = EagerInitialization.GetInstance;
                school.PrintDetails("School");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Employees the details.
        /// </summary>
        public static void EmployeeDetails()
        {
            try
            {
                LazyInitialization employe = LazyInitialization.GetInstance;
                employe.PrintDetails("Employe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Companies the details.
        /// </summary>
        public static void CompanyDetails()
        {
            try
            {
                LazyInitialization cmpany = LazyInitialization.GetInstance;
                cmpany.PrintDetails("Company");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Managers the details.
        /// </summary>
        public static void ManagerDetails()
        {
            try
            {
                LazyInitialization manager = LazyInitialization.GetInstance;
                manager.PrintDetails("Manager");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Hrs the details.
        /// </summary>
        public static void HrDetails()
        {
            try
            {
                LazyInitialization hr = LazyInitialization.GetInstance;
                hr.PrintDetails("Hr");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void FactoryDetails()
        {
            try
            {
                BillPughSingleton factry = BillPughSingleton.GetInstance;
                factry.PrintDetails("Factory");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void IndustryDetails()
        {
            try
            {
                BillPughSingleton industry = BillPughSingleton.GetInstance;
                industry.PrintDetails("Industry");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
