using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.ObsereverPattern
{
    /// <summary>
    /// /The ConcreteSubject class
    /// </summary>
    /// <seealso cref="Design_Pattern.ObsereverPattern.Subject" />
    class ConcreteSubject : Subject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteSubject"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public ConcreteSubject(double price) : base(price)
        {

        }
        
    }
}
