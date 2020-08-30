using System;

namespace VendingMachine
{
    public abstract class BaseVMClass
    {
        public string Declaration { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public abstract void Examine();
        public abstract void Purchase();
    }
}
