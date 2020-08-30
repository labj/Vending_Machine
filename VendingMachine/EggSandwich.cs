using System;

namespace VendingMachine
{
    public class EggSandwich : Food
    {
        const string text = "Food: Egg Sandwich";
        const string name = "Egg bread";

        public EggSandwich(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("9.  ".PadLeft(7));

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
