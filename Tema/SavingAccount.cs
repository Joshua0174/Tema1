using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal class SavingAccount: BankAccount,IBancarOp  //mostenire, abstractizare
    {
        public SavingAccount(string holder,string iban, double sold, string password) : base(holder,iban, sold, password) { 
        }
        public void Deposit(double value)
        {
            Sold += value;
            Console.WriteLine("Ati depus "+ value+" lei.");
            Console.WriteLine("Sold curent: " + Sold);
        }

        public void WithDrawal(double value)
        {
            if (Sold - value >= 0)
            {
                Sold -= value;
                Console.WriteLine("Au fost retrasi "+ value, " lei.");
            }
            else
            {
                Console.WriteLine("Sold insuficient.");
            }
        }
        
    }
}
