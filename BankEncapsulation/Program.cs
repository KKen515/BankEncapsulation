namespace BankEncapsulation
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            bool bankLoop = true;
            Console.WriteLine("Welcome to the Bank Encapsulation Service!");
            
            
            while (bankLoop)
            {
                BankAccount ba = new BankAccount();

                Console.WriteLine("Would you like to deposit anything? Y or N");
                char userInput = Console.ReadKey().KeyChar;

                if (userInput == 'y' || userInput == 'Y')
                {
                    Console.WriteLine($"\n");
                    Console.WriteLine("How much do you want to deposit?");

                    double amountToDeposit = double.Parse(Console.ReadLine());
                    ba.Deposit(amountToDeposit);

                    double userBalance = ba.GetBalance();

                    Console.WriteLine($"Your current balance is: {userBalance,0:c}.");

                }
                else if (userInput == 'n' || userInput == 'N')
                {
                    Console.WriteLine($"\n");
                    Console.WriteLine("Thank you for using the Bank Encapsulation Service!");
                    bankLoop = false;
                }
                else
                {
                    Console.WriteLine($"\n");
                    Console.WriteLine("Invalid input, try again.");
                }

                

            }
        }
    }
}
