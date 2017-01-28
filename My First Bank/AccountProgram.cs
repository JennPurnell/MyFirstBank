using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Bank
{
    class AccountProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to my bank!******");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("Please select one of the options from above:");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Please enter your email address:");
                        var emailAddress = Console.ReadLine();
                        var myAccount = new Account(emailAddress);
                        Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C} ");
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    default:
                        Console.WriteLine("Sorry, option not available");
                        break;

                }
            }
            ////create an account object/instance
            //var myAccount = new Account();
            //myAccount.EmailAddress = "test@test.com";
            //myAccount.Deposit(200.50M);
            //Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C} ");

            //var myAccount2 = new Account("test2@test.com");
            ////myAccount2.EmailAddress = "test@test.com";
            //myAccount2.Deposit(200.50M);
            //Console.WriteLine($"The balance in my account - {myAccount2.AccountNumber} is {myAccount2.Balance:C} ");

            //var myAccount3 = new Account("test2@test.com", 200.50M);
            ////myAccount2.EmailAddress = "test@test.com";
            ////myAccount3.Deposit(200.50M);
            //Console.WriteLine($"The balance in my account - {myAccount3.AccountNumber} is {myAccount3.Balance:C} ");

        }
    }
}
