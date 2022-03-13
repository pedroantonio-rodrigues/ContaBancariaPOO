namespace Banco
{
public class ContaBancariaPF : contaBancaria
{       
    public ContaBancariaPF(string nomeUsuario, decimal saldo, string numeroConta, string tipoConta, int Saque) : base (nomeUsuario, saldo, numeroConta, tipoConta, Saque)
        {
        }
        public void saque(int valor)
        {
            decimal taxa = 0.01;
            if (this.saques >= 1)
            {
                this.saldo -= valor;
                --this.saques;
            }
              else if(this.saldo < valor)
                {
                  this.saldo -= valor
                }
            else
            {
                decimal desconto = valor * taxa;
                this.saldo -= (valor + desconto);
            }
        }
            public void deposito(decimal valor)
            {
                decimal taxa = 0.01;
                decimal desconto = valor * taxa;
                this.saldo += (valor + desconto);
            }
        }
}
