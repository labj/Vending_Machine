using System;

namespace VendingMachine
{
    public class SparklingWater : Drink
    {
        const string text = "Drink: Sparkling Water";
        const string name = "Water";

        public SparklingWater(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("2.  ".PadLeft(7));

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
            DrinkDrink();
        }
    }
}
