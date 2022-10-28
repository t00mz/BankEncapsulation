namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myBankAcc = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            
            var depAmount = double.Parse(Console.ReadLine());

            myBankAcc.Deposit(depAmount);

            Console.WriteLine($"Your balance is now ${myBankAcc.GetBalance()}");
        }
    }
}
