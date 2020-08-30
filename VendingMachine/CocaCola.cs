using System;

namespace VendingMachine
{
    public class CocaCola : Drink
    {
        const string text = "Drink: Coca-Cola";
        const string name = "Coke";

        public CocaCola(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("1.  ".PadLeft(7));

            base.Examine();
        }

        public void Use()
        {
            DrinkDrink();
        }

        public override void Purchase()
        {
            if (Quantity <= 0)
            {
                throw new ArithmeticException($"There are no more {Name} left!");
            }
            Quantity -= 1;
        }
    }
}
