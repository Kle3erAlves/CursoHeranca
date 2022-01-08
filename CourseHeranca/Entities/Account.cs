
namespace CourseHeranca.Entities
{
    class Account  ///CLASSE DA CONTA
    {
        public int Number { get; private set; }  //PROPRIEDADE NUMERO DA CONTA (com encapsulamento)
        public string Holder { get; private set; } // PROPRIEDADE DO TITULAR (com encapsulamento)
        public double Balance { get; protected set; } //PROPRIEDADE SALDO (com encapsulamento)
        //ENCAPSULAMENTO "private": PERMITE APENAS O ACESSO AO ATRIBUTO, NÃO É POSSIVEL ALTERAR
        //ENCAPSULAMENTO "protected": PERMITE QUE APENAS AS SUBCLASSES POSSAM ALTERAR, EX: "Balance"
        
        public Account() // CONSTRUTOR INICIAL DA CONTA
        {
        }

        public Account(int number, string holder, double balance) //CONSTRUTOR GERAL DA CONTA
        { //PARAMETROS DO CONSTRUTOR DA CONTA
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //METODO SAQUE
        public virtual void Withdraw (double amount) //O METODO RECEBI A VARIAVEL QUANTIA
            //A PALAVRA virtual possibilita que o metodo seja subscrito por subclasses
        {                                 //{
            Balance -= amount + 5.0; // METODO PARA SUBTRAIR A QUANTIA DO SALDO
        }
        //METODO DEPOSITO
        public void Deposit (double amount) //O METODO RECEBI A VARIAVEL QUANTIA
        {
            Balance += amount; // METODO PARA ADICIONAR A QUANTIA AO SALDO
        }

    }
}
