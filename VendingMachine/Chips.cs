using System;

namespace VendingMachine
{
    public class Chips : Snack
    {
        const string text = "Snack: Chips";
        const string name = "Chips";

        public Chips(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("6.  ".PadLeft(7));

            base.Examine();
        }

        public override void Purchase()
        {
            if (Quantity <= 0)
            {
                throw new ArithmeticException($"There are no more {Name} left!");
            }
            Quantity -= 1;
        }

        public void Use()
        {
            EatSnack();
        }
    }
}
