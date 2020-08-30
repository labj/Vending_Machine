using System;

namespace VendingMachine
{
    public class VMachine : BaseVMClass
    {
        private const int nrOfDenominations = 8;

        private int[] moneyArray = new int[nrOfDenominations]; // 1000, 500, 100, 50, 20, 10, 5, 1 kr
        private readonly int[] denominations = new int[nrOfDenominations] { 1000, 500, 100, 50, 20, 10, 5, 1 };

        private CocaCola coke = new CocaCola(25, 3);
        private SparklingWater water = new SparklingWater(21, 3);
        private OrangeJuice juice = new OrangeJuice(28, 3);
        private Japp japp = new Japp(18, 3);
        private Biscuits biscuits = new Biscuits(20, 3);
        private Chips chips = new Chips(35, 3);
        private HamSandwich hamBread = new HamSandwich(50, 3);
        private CheeseSandwich cheeseBread = new CheeseSandwich(45, 3);
        private EggSandwich eggBread = new EggSandwich(40, 3);


        private int[] DivideMoneyIntoDenominations(int kr)
        {
            int[] moneyArr = new int[nrOfDenominations];

            for (int i = 0; i < nrOfDenominations; i++)
            {
                moneyArr[i] = kr / denominations[i];
                kr -= moneyArr[i] * denominations[i];
            }

            return moneyArr;
        }

        private int HowMuchMoneyLeft()
        {
            int moneyLeft = 0; 

            for (int i = 0; i < nrOfDenominations; i++)
            {
                moneyLeft += moneyArray[i] * denominations[i];
            }

            return moneyLeft;
        }

        public void PutInMoney(int kr)
        {
            moneyArray = DivideMoneyIntoDenominations(kr);
        }

        public int GetChange()
        {
            int money = 0;

            for (int i = 0; i < nrOfDenominations; i++)
            {
                money += moneyArray[i] * denominations[i];
                moneyArray[i] = 0;
            }

            return money;
        }

        private void PayMoney(BaseVMClass item)
        {
            int moneyLeft = HowMuchMoneyLeft() - item.Price;

            if (moneyLeft >= 0) // Doing this even if moneyLeft = 0 to reset moneyArray
            {
                try
                {
                    item.Purchase();
                }
                catch
                {
                    throw; // Just to move the exception upwards to be catched in the Purchase method below.
                }

                moneyArray = DivideMoneyIntoDenominations(moneyLeft);
            }
            else
            {
                throw new ArithmeticException($"Tried to pay for more than it was money in the machine {moneyLeft}");
            }
        }

        public override void Examine()
        {
            Console.WriteLine($"\nMoney left in machine = {HowMuchMoneyLeft()}.\n");
            Console.WriteLine("ID   ".PadLeft(7) + "Declaration".PadRight(25) + "Quantity".PadLeft(8) + "Price".PadLeft(8));
            Console.WriteLine();

            coke.Examine();
            water.Examine();
            juice.Examine();
            japp.Examine();
            biscuits.Examine();
            chips.Examine();
            hamBread.Examine();
            cheeseBread.Examine();
            eggBread.Examine();

            Console.WriteLine();
        }

        public override void Purchase()
        {
            Console.Write("Choose a number from 1-9: ");

            string number = Console.ReadLine();

            Console.WriteLine();

            switch (number)
            {
                case "1":
                    try
                    {
                        PayMoney(coke);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a coke can.\n");

                    coke.Use();
                    break;

                case "2":
                    try
                    {
                        PayMoney(water);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a water can.\n");

                    water.Use();
                    break;

                case "3":
                    try
                    {
                        PayMoney(juice);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a juice can.\n");

                    juice.Use();
                    break;

                case "4":
                    try
                    {
                        PayMoney(japp);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a japp.\n");

                    japp.Use();
                    break;

                case "5":
                    try
                    {
                        PayMoney(biscuits);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a biscuit.\n");

                    biscuits.Use();
                    break;

                case "6":
                    try
                    {
                        PayMoney(chips);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a bagful of chips.\n");

                    chips.Use();
                    break;

                case "7":
                    try
                    {
                        PayMoney(hamBread);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a ham sandwich.\n");

                    hamBread.Use();
                    break;

                case "8":
                    try
                    {
                        PayMoney(cheeseBread);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting a cheese sandwich.\n");

                    cheeseBread.Use();
                    break;

                case "9":
                    try
                    {
                        PayMoney(eggBread);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    Console.WriteLine("Getting an egg sandwich.\n");

                    eggBread.Use();
                    break;

                default:
                    Console.WriteLine("Number should be between 1-9.");
                    break;
            }

            Console.WriteLine($"\nMoney left in machine = {HowMuchMoneyLeft()}.\n");

            Console.WriteLine();
        }
    }
}
