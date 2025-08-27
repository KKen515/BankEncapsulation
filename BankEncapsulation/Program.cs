namespace BankEncapsulation
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            bool loop;
            var account = new BankAccount();

          Console.WriteLine("Welcome to the Bank Encapsulation App!");
          Console.WriteLine("-----------------------------------------");

          while (loop = true)
          {
              Console.WriteLine("\n Please select an option:");
              Console.WriteLine("1. Deposit Money");
              Console.WriteLine("2. Get Balance");
              Console.WriteLine("3. Exit the Application");

              int choice;
              if (!int.TryParse(Console.ReadLine(), out choice))
              {
                  Console.WriteLine("Invalid choice. Please enter a valid input.");
                  continue;
              }

              switch (choice)
              {
                  case 1:
                      Console.WriteLine("Enter the amount you want to deposit: ");

                      double amount;

                      if (!double.TryParse(Console.ReadLine(), out amount))
                      {
                          Console.WriteLine("Invalid choice. Please enter a valid input.");
                          continue;
                      }
                      account.Deposit(amount);
                      Console.WriteLine("Deposit successfully!");
                      break;
                  
                  case 2:
                      Console.WriteLine($"Current Balance: ${account.GetBalance()}");
                      break;
                  case 3:
                      Console.WriteLine("Thank you for using the Bank Encapsulation App!");
                      return;
                  default:
                      Console.WriteLine("Invalid input. Please enter a valid input.");
                      break;
              }
              
          }
        }
    }
}
