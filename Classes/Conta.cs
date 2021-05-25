using System; 

namespace Dio.Bank
{
    public class Conta
    {
        public string Nome {get;set;}
        private double Credito {get;set;}

        private double Saldo {get;set;}

        private TipoConta TipoConta {get;set;}



        public Conta (TipoConta tipoConta, double saldo, double credito,string nome)
        {
             this.TipoConta = tipoConta;
             this.Saldo= saldo;
             this.Credito = credito;

        }

        public bool Sacar (double valorSaque)
        {
            if(this.Saldo - valorSaque <(this.Credito *-1)){
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
            this.Saldo-=valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;

        }
            public void Depositar(double valorDeposito)
            {
                this.Saldo += valorDeposito;

                Console.WriteLine("Saldo atual da conta de {0} é {1}",this.Nome, this.Saldo);

            }

            public void Tranferir (double valortransferencia, Conta ContaDestino)
            {
                if(this.Sacar(valortransferencia)){
                    ContaDestino.Depositar(valortransferencia);
                }

            }
        public override string ToString()
        {
            string retorno = " ";
            retorno += "Tipo Conta" + this.TipoConta + " | ";
            retorno += "Nome" + this.Saldo +" | ";
            retorno += "Crédito" + this.Credito;
            return retorno;
        }






            

    } 
}