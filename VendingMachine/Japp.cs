using System;

namespace VendingMachine
{
    public class Japp : Snack
    {
        const string text = "Snack: Chocolate bite";
        const string name = "Choco";

        public Japp(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("4.  ".PadLeft(7));

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
