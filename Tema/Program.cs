using System;
using System.Collections.Generic;
using Tema;


//Am implementat o banca. Clientul isi poate crea un cont, il poate dezactiva, poate retrage si depune bani. 
//Exista doua tipuri de conturi: 
//-cont de economii(SavingAccount) unde banii pot fi depusi si scosi din bancomat dupa o anumita perioada
//-cont clasic(CashDeposit) unde se pot depune si scoate bani oricand, indiferent de suma.
//
//In interfata IBancarOp am definit 2 metode: retragere si depunere de bani. Pentru fiecare tip de cont
//aceste operatii sunt implementate diferit.
//Clasa statica Accounts joaca rolul unei baze de date pentru ce userii celor doua tipuri de conturi.
//Am folosit mostenirea pentru a defini cele doua tipuri de conturi. Tot aici apare si polimorfismul.
//Am folosit incapsularea atunci cand izolat setarea parolei, a ibanului, a parolei si a titularului de card.
//Abstractizarea am folosit-o implementand interfata IBancarOp.
class Program
{
    static void Main(string[] args)
    {
          var acc1= new SavingAccount("Mirel Ghita", "2315321235123", 768.2, "2354"); 
          var acc2 = new CashDeposit("Petre Stefan", "2315321235125",12.9, "1934", new DateTime(2026,12,5));
          Accounts.AddSavingAccount(acc1);  
          Accounts.AddCashDepositCard(acc2);
          Accounts.cashDeposits[0].Deposit(700);
          Accounts.savingAccounts[0].Deposit(5);
          Accounts.savingAccounts[0].WithDrawal(1500);
          //aici pot fi aduagate mai multe operatiuni bancare. 
          //as mai putea adauga alte operatiuni bancare in interfata (cerereImprumut, transfer de bani, etc)
    }
}
