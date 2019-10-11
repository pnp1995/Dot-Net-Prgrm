using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.ObsereverPattern
{
    /// <summary>
    /// /The Observer interface
    /// </summary>
    interface IObserver
    {
        void Update(Subject subject);
    }
}
