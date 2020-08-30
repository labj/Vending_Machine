using System;

namespace VendingMachine
{
    public class Snack : BaseVMClass
    {
        protected void EatSnack()
        {
            Console.WriteLine($"Eating {Name} snack.");
        }

        public override void Examine()
        {
            Console.WriteLine(Declaration.PadRight(25) + Quantity.ToString().PadLeft(8) + Price.ToString().PadLeft(8));
        }

        public override void Purchase()
        {
            throw new NotImplementedException();
        }
    }
}