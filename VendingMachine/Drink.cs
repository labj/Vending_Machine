using System;

namespace VendingMachine
{
    public class Drink : BaseVMClass
    {
        protected void DrinkDrink()
        {
            Console.WriteLine("You are drinking a can of " + Name + ".");
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
