using System;
using CourseHeranca.Entities;

namespace CourseHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING -------------OPERÃÇÃO INSEGURA----USAR SE NECESSÁRIO

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3; ----- O COMPILADOR ACEITA E NÃO ACUSA ERRO
            //PORQUE HOUVE UMA CONVERSÃO IMPLICITA DE CASTING ENTRE AS DUAS SUBCLASSES DISTINTAS, PORÉM 
            //DETECTA O ERRO NO TEMPO DE COMPILAÇÃO DO PROGRAMA, ACUSANDO NÃO HAVER COMPATIBILIDADE ENTRE 
            //AS DUAS SUBCLASSES NÃO ASSOCIADAS.

            //OPERADOR IS
            if (acc3 is BusinessAccount) //TESTA SE O ACC3 É UMAS INSTANCIA DO "BUSINESSACCOUNT" (NÃO É!!"
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; //CASTING DO ACC3
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }
            //OPERADOR IS
            if (acc3 is SavingAccount) //TESTANDO SE ACC3 É UMA INSTANCIA DO "SAVINGACCOUNT"
            {
                SavingAccount acc5 = (SavingAccount)acc3; //CASTING DO ACC3
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


        }
    }
}
