using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal abstract class BankAccount  //abstractizare
    {                                    
        public string Iban { get; private set; } 
        public double Sold { get; set; }
        public string Password { get; private set; } //incapsulare- modificarile pentru parola, titular, Iban, valabilitatea contului se
                                                     //pot face doar din interiorul clasei
        public string Holder { get; private set;}
        //public int Id { get; private set; }
        public bool Active {  get; private set; }
        public BankAccount(string holder, string iban, double sold, string password) {
            Holder = holder;
            Iban = iban;
            Sold = sold;
            Password = password;
            //alocateId();
        }
        
        //M-am gandit sa fac un login pentru fiecare utilizator. Cand vine la bancomat, utilizatorul
        //se logheaza cu id-ul (care ar trebui sa fie unic, insa codul meu nu garanteaza asta) si cu parola. Metoda comentata seteaza un
        //id pt fiecare persoana, indiferent de tipul contului. 
        //private void alocateId()   
        //{
        //    string aux="";
        //    string[] M = { "0","1", "2", "3","4", "5", "9", "6" };
        //    for (int i = 0; i < 5; i++) {
        //        Random rnd = new Random();
        //        aux += M[rnd.Next(0, M.Length)];
        //    }
        //    Id=int.Parse(aux);
        //}
        public void setActive(bool ok) {
            if (Sold > 0) {
                Console.WriteLine("Retrage banii, apoi inchide contul!");
            }
            else Active= ok;
        }
    }
}
