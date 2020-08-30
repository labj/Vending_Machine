using System;

namespace VendingMachine
{
    public class OrangeJuice : Drink
    {
        const string text = "Drink: Orange juice";
        const string name = "Juice";

        public OrangeJuice(int price, int quant)
        {
            Price = price;
            Declaration = text;
            Name = name;
            Quantity = quant;
        }

        public override void Examine()
        {
            Console.Write("3.  ".PadLeft(7));

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
