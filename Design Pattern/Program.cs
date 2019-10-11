// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using Design_Pattern.FactoryPattern;
using System;

namespace Design_Pattern
{
    class Program
    {
        public static void Main()
        {  
            try
            {
                int choice;
                do
                {
                    Console.WriteLine("Enter the choice");
                    Console.WriteLine("1.Factory Pattern\n2.SingletonPattern\n3.PrototypeDesign Pattern\n4.AdapterDesignPattern\n5.FacadeDesignPattern");
                    Console.WriteLine("\n6.ProxyPattern\n7.ObserverPattern\n8.VisitorPattern\n9.MediaterPattern\n10.Reflection\n11.DependncyInjection");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Test test = new Test();
                            test.main();
                            break;
                        case 2:
                            SingletonPattern.Singleton.SingletonOperation();
                            break;
                        case 3:
                            PrototypeDesign.Prototype prototype = new PrototypeDesign.Prototype();
                            prototype.PrototypePattern();
                            break;
                        case 4:
                            AdapterDesignPattern.Adapter adapterobj = new AdapterDesignPattern.Adapter();
                            adapterobj.adapter();
                            break;
                        case 5:
                            FacadeDesignPattern.Order facade = new FacadeDesignPattern.Order();
                            facade.GetOrder();
                            break;
                        case 6:
                            ProxyPattern.Proxy.pattern();
                            break;
                        case 7:
                            ObsereverPattern.ObserverMain.ObserverPattern();
                            break;
                        case 8:
                            VisitorPattern.VisitorMain.Pattern();
                            break;
                        case 9:
                            MediaterPattern.MediaterDesign.Pattern();
                            break;
                        case 10:
                            Reflection.Reflection reflection = new Reflection.Reflection();
                            reflection.ReflectionMain();
                            break;
                        case 11:
                            DependencyInjection.Dependency dependency = new DependencyInjection.Dependency();
                            dependency.Dependencyinjection();
                            break;
                    }
                    Console.WriteLine("Do you want to continue then press y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y') ;
                }
            catch(Exception ex)
            { 
            Console.WriteLine(ex.Message);
            }
        }

    }
}
