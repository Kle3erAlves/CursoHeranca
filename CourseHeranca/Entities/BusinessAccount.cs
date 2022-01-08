

namespace CourseHeranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) //variaveis dos construtores, tanto da superclasse quando da subclasse
        : base(number, holder, balance) //construtores da superclasse
        {
            LoanLimit = loanLimit; // construtores da subclasse
        }
        //METODO EMPRESTIMO
        public void Loan (double amount) //RECEBE VARIAVEL QUANTIA
        {
            if (amount <= LoanLimit) //TESTA SE A QUANTIA É MENOR QUE O LIMITE
            {
                Balance += amount; //ADICIONA A QUANTIA AO SALDO
            }
        }
    }
}
