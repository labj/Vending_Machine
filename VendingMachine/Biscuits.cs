using System;

namespace VendingMachine
{
    public class Biscuits : Snack
    {
        const string text = "Snack: Biscuit";
        const string name = "Biscuit";

        public Biscuits(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("5.  ".PadLeft(7));

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
