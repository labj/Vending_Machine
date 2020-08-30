using System;

namespace VendingMachine
{
    public class Food : BaseVMClass
    {
        protected void EatFood()
        {
            Console.WriteLine($"Eating the {Name} sandwich.");
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
