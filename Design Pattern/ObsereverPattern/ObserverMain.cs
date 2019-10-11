using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.ObsereverPattern
{
    public class ObserverMain
    {
       public static void ObserverPattern()
        {
            // Create price watch for Concrete and attach ConcreteObserver that buy concrete from suppliers.
            ConcreteSubject concrete = new ConcreteSubject(0.82);
            concrete.Attach(new ConcreteObserver("Mackay's", 0.77));
            concrete.Attach(new ConcreteObserver("Johnny's Sports Bar", 0.74));
            concrete.Attach(new ConcreteObserver("Salad Kingdom", 0.75));

            // Fluctuating concrete prices will notify subscribing restaurants.
            concrete.Price = 0.79;
            concrete.Price = 0.76;
            concrete.Price = 0.74;
            concrete.Price = 0.81;

            Console.ReadKey();
        }
    }
}
