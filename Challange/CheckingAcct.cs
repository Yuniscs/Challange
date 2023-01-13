using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
     class CheckingAcct
     {
        public string Name;
        public string Surname;
        public decimal Balance;
        
        public CheckingAcct(string name,string surname, decimal initialbalance) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Balance = initialbalance;
        }
        public string AccountOwner()
        {
            string name = "John";
            string surname = "Doe";
            return name + " " + surname;
        }
        public decimal MakeDeposit()
        {            
            Console.WriteLine("Deposit some money in John account:");
            decimal amount =decimal.Parse(Console.ReadLine());
            Balance +=amount;
            return Balance;           
        }
        public decimal MakeWithdraw()
        {
            Console.WriteLine("Make some withdrawals from in John account:");
            decimal amount=decimal.Parse(Console.ReadLine());
            Balance -= amount;
            return Balance;
        }
        public decimal TryToOwerdraw()
        {
            decimal extracharge = 35.00m;
            Console.WriteLine("CheckingAcct enter the amount:");
            decimal amount =decimal.Parse(Console.ReadLine());
            if(Balance >=amount)
            {
                return Balance -= amount;
            }
            else if(Balance < amount)
            {
                return Balance -=amount + extracharge;
            }
            return Balance;
        }








    }
}
