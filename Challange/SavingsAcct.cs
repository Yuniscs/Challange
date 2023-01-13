using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
    internal class SavingsAcct
    {
        public string Name;
        public string Surname;
        public decimal Interest;
        public decimal Balance;
        public decimal Withdrawals;
        public SavingsAcct(string name, string surname, decimal interest, decimal initialbalance)
        {
            this.Name = name;
            this.Surname = surname;
            this.Interest = interest;
            this.Balance = initialbalance;            
        }
        public string AccountOwner()
        {
            string name = "Jane";
            string surname = "Doe";
            return name + " " + surname;
        }
        public decimal MakeDeposit()
        {
            Console.WriteLine("Deposit some money in Jane account:");
            decimal amount = decimal.Parse(Console.ReadLine());
            return Balance += amount;            
        }
        public decimal MakeWithdraw()
        {
            Console.WriteLine("Make some withdrawals from in Jane account:");
            decimal amount = decimal.Parse(Console.ReadLine());
            return Balance -= amount;                      
        }

        int amountacct = 0;
        public decimal Withdraw(decimal amount)
        {
            Console.WriteLine("More than 3 Savings withdrawals should result in 2.00 charge");
            if (amount < Balance)
            {
                if (amountacct >=2)
                {
                    decimal commission = 2.00m;
                    return Balance -=amount + commission;
                }           
                else
                {
                    amountacct++;
                    return Balance -= amount;                   
                }
            }            
            return Balance;                    
        }
        public decimal ApplyInterest(decimal interest)
        {
            Console.WriteLine("Apply the Savings interest:");
            return Balance += Balance * interest;            
        }
        public decimal TryToOwerdraw()
        {
            Console.WriteLine("SavingAcct enter the amount:");
            decimal amount = decimal.Parse(Console.ReadLine());
            if(Balance>=amount)
            {
                return Balance-=amount;
            }
            else 
            {
                Console.WriteLine("It is not possible...");
            }
            return Balance;
        }
           
    }
}
