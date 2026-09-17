using System;

namespace Encapsulation
{
    class Account
    {
        // Private field
        private int AccountBalance = 3000;

        // Method to change the balance
        public void SetBalance(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("You cannot enter a negative value.");
            }
            else
            {
                AccountBalance = amount;
            }
        }

        // Method to display the balance
        public void GetBalance()
        {
            Console.WriteLine($"The amount is {AccountBalance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account MyAccount = new Account();

            MyAccount.SetBalance(3000);
            MyAccount.GetBalance();

            Console.ReadLine();
        }
    }
}