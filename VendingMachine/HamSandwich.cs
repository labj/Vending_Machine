using System;

namespace VendingMachine
{
    public class HamSandwich : Food
    {
        const string text = "Food: Ham Sandwich";
        const string name = "Ham bread";

        public HamSandwich(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("7.  ".PadLeft(7));

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
            EatFood();
        }
    }
}
