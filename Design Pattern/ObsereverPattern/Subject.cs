using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.ObsereverPattern
{
    class Subject
    {
        private double price;
        private List<IObserver> observers = new List<IObserver>();

        public Subject(double price)
        {
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    //Automatically notify our observers of price changes
                    Notify();
                }
            }
        }
    }
}
