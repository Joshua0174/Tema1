using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal static class Accounts  //baza de date cu conturi
    {
        public static List<CashDeposit> cashDeposits = new List<CashDeposit>();
        public static List<SavingAccount> savingAccounts = new List<SavingAccount>();
        public static void AddCashDepositCard(CashDeposit cd) {
            if (cashDeposits.Contains(cd)) {
                Console.WriteLine("Acest cont deja exista.");
            }
            else { 
                cashDeposits.Add(cd);
                Console.WriteLine("Contul lui "+ cd.Holder +" a fost creat cu succes");
            }
        }
        public static void AddSavingAccount(SavingAccount sv) { 
            if(savingAccounts.Contains(sv))
            {
                Console.WriteLine("Acest cont deja exista");
            }
            else { 
                savingAccounts.Add(sv);
                Console.WriteLine("Contul de economii al lui " + sv.Holder);
            }
        }
        public static void pauseAccount(String iban){
            var account = cashDeposits.SingleOrDefault(x => x.Iban == iban);//lambda expression-- ia un x si cauta print toti vizitatorii pana il gaseste pe cel cu idul coresp
            if (account != null)
            {
                account.setActive(false);
                Console.WriteLine("Visitor desactivated.");
            }
        }

        public static void Login(int id){}
    }
}
