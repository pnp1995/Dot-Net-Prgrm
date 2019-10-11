using System;

namespace Design_Pattern.SingletonPattern
{
    internal class Bill<T>
    {
        private Func<BillPughSingleton> p;

        public Bill(Func<BillPughSingleton> p)
        {
            this.p = p;
        }
    }
}