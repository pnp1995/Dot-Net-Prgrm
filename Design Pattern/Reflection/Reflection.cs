// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Reflection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace Design_Pattern.Reflection
{
    /// <summary>
    /// Reflectrion is a class.
    /// </summary>
    class Reflection
    {
        public void ReflectionMain()
        {
            Type type = Type.GetType("Design_Pattern.Reflection.Employee");
            Console.WriteLine("Full Name = {0}", type.FullName);
            Console.WriteLine("Namespace Name = {0}", type.Namespace);
            Console.WriteLine("Class Name = {0}", type.Name);
            Console.WriteLine("\nProperties in Employee");
            Console.WriteLine();
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach(PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine("Method in Employees");
            Console.WriteLine("");
            MethodInfo[] methodInfos = type.GetMethods();
            foreach(MethodInfo method in methodInfos)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("Constructor in Employee");
            Console.WriteLine(" ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
