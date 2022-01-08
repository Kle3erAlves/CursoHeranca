
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
    }

  
}
