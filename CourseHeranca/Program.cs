using System;
using CourseHeranca.Entities;

namespace CourseHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount
            (8010, "Bob Brown", 100, 500);

            Console.WriteLine(account.Balance);
            //  account.Balance = 200;     "ESTE ERRO É DEVIDO O ACESSO A PROPRIEDADE "BALANCE" SER "PROTECTED"

        }
    }
}
