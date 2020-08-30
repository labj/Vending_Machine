using System;

namespace VendingMachine
{
    class MainClass
    {
        /***********************************************************************
         * 
         * Vending Machine
         * 
         * Att läsa in hur mycket pengar som skall laddas in i maskinen går fel 
         * om det inte endast är siffror som skrivs in. Kan man antagligen lösa
         * med Parse eller TryParse på Int32.
         * 
         * Via Examine använder jag en distribuerad utskriftshantering av menyn.
         * Kanske inte så snyggt gjort men det fick bli så. I Examine i 
         * VMachine-klassen anropar jag samtliga sorters drickors, snacks
         * och food Examine och skriver ut vad som är unikt för den varan.
         * 
         * Jag låter sedan anropa basklassens Examine och i den skriver jag ut
         * resterande information. Dock skall sägas att samma kod för Examine 
         * ligger i Drink, Snack och Food i Examine vilket kanske inte är så
         * snyggt. 
         * 
         * Alla beräkningar sker i VMachine. Jag har valt att gå runt 
         * hanteringen av att dra en summa från poolen med pengar genom att
         * hämta nuvarande summa och subtrahera priset för köpt vara och 
         * därefter på nytt bygga upp pengapoolen. Att dra en viss summa från 
         * pengapoolen skulle inneburit en hel del beräkningar som jag inte 
         * fick ihop så jag förenklade.
         * 
         **********************************************************************/

        public static void Main(string[] args)
        {
            VMachine VM = new VMachine(); // One object of the VMachine class.

            int money;
            bool endOfPurchases = false;
            bool endOfBuying;

            do
            {
                // Read from the console how much money to put into the Vending Machine. 
                Console.Write("\nHow much money in kr do you want to put into the machine? ");
                money = Convert.ToInt32(Console.ReadLine());

                VM.PutInMoney(money);

                endOfBuying = false;

                while (!endOfBuying)
                {
                    // Look at the line of products with declarations, quantity and their prices.
                    VM.Examine();

                    // Choose an article to buy.
                    VM.Purchase();

                    if (!ContinueBuying("Continue buying with the sum of money in the machine? (Y/N) "))
                    {
                        endOfBuying = true;
                    }
                }

                Console.WriteLine($"\nChange is = {VM.GetChange()}\n");

                if (!ContinueBuying("Do you want to continue bying and put a new sum into the machine? (Y/N) "))
                {
                    endOfPurchases = true;
                }

            } while (!endOfPurchases);
        }

        private static bool ContinueBuying(string buy)
        {
            bool result = false;
            bool endLoop = false;
            string answer;

            do
            {
                Console.Write(buy);
                answer = Console.ReadLine();

                if (answer.Length > 0 && (answer[0] == 'y' || answer[0] == 'Y'))
                {
                    result = true;
                    endLoop = true;
                }
                else if (answer.Length > 0 && (answer[0] == 'n' || answer[0] == 'N'))
                {
                    endLoop = true;
                }

            } while (!endLoop);

            return result;
        }
    }
}
