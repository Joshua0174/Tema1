using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal class CashDeposit : BankAccount, IBancarOp
    {

        double minimumValue = 1000.0;
        public CashDeposit(string holder, string iban, double sold, string password, DateTime period) : base(holder, iban, sold, password)
        {
            Period = period;
        }

        public DateTime Period { get; private set; }
        public void Deposit(double value)
        {
            if (value > minimumValue) { 
            Sold += value;
            Console.WriteLine("Ati depus "+ value+ " lei.");
            Console.WriteLine("Sold curent: "+ Sold);
            }
            else { Console.WriteLine("Suma minima care poate fi depusa este de: "+ minimumValue); }
        }

        public void WithDrawal(double value)
        {
            if (Period.Year >= DateTime.Now.Year) { 
                 if (Sold - value >= 0)
                 {
                Sold -= value;
                Console.WriteLine("Au fost retrasi "+ value+ " lei.");
                 }
                else
                {
                  Console.WriteLine("Sold insuficient.");
                }
            }
            else {Console.WriteLine("Banii pot fi retrasi incepand cu data de "+ Period ); }

        }
    }
}
