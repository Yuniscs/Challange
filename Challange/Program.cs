using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAcct checking = new CheckingAcct("John", " Doe", 2500.0m);
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");

            SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.025m, 1000.0m);
            Console.WriteLine($"Savings balance is {saving.Balance:C2}\n");

            Console.WriteLine($"Checking owner:{checking.AccountOwner()}\nSavings owner:{saving.AccountOwner()}\n");

            Console.WriteLine($"Checking balance is {checking.MakeDeposit():C2}\n\n");

            Console.WriteLine($"Checking balance is {saving.MakeDeposit():C2}\n\n");

            Console.WriteLine($"Checking balance is {checking.MakeWithdraw():C2}\n\n");

            Console.WriteLine($"Checking balance is {saving.MakeWithdraw():C2}\n\n");

            Console.WriteLine($"Savings balance is{saving.ApplyInterest(0.025m)}\n");
            
            Console.WriteLine(saving.Withdraw(10m));
            Console.WriteLine(saving.Withdraw(20m));
            Console.WriteLine(saving.Withdraw(30m));
            //Console.WriteLine(saving.Commission(40m)); 
            Console.WriteLine($"Savings balance is{saving.TryToOwerdraw():C2}\n");
            Console.WriteLine($"Checking balance is{checking.TryToOwerdraw()}");
            Console.ReadLine();






        }

    }
}
