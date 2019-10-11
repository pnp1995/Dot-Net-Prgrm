using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.ObsereverPattern
{
    /// <summary>
    /// The ConcreteObserver class
    /// </summary>
    /// <seealso cref="Design_Pattern.ObsereverPattern.IObserver" />
    class ConcreteObserver : IObserver
    {
        private string name;
        private Subject subject;
        private double purchaseThreshold;

        public ConcreteObserver(string name, double purchaseThreshold)
        {
        }
        public void Update(Subject subject)
        {
            Console.WriteLine("Notified {0} of {1}'s " + " price change to {2:C} per pound.", name, subject.GetType().Name, subject.Price);
            if (subject.Price < purchaseThreshold)
            {
                Console.WriteLine(name + " wants to buy some " + subject.GetType().Name + "!");
            }
        }
    }
}
