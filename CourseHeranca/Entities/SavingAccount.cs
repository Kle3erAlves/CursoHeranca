
namespace CourseHeranca.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; } //Taxa de juros

        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        //METODO ATUALIZA SALDO DA CONTA
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //METODO DE SAQUE COM ALTERAÇÃO (SUBSCRITO)

        public sealed override void Withdraw(double amount)
        // A PALAVRA "sealed" SIGNIFICA QUE ESTE METODO NÃO PODE SER SUBSCRITO NOVAMENTE
        {
            base.Withdraw(amount); //REAPROVEITA A OPERAÇÃO DA SUPERCLASSE
            Balance -= 2.0;
        }
    }

  
}
