namespace Banco
{
public class ContaPR : contaBancaria
{
        public ContaPR(string nomeUsuario, decimal saldo, string numeroConta, string tipoConta, int Saque) : base(nomeUsuario, saldo, numeroConta, tipoConta, Saque)
        {
        }
            public void saque(decimal valor)
            {
                decimal taxa = 0.02;
                if (this.saques >= 1)
                {
                    this.saldo -= valor;
                    --this.saques;
                }
                 else 
                {
                    decimal desconto = valor * taxa;
                    this.saldo -= (valor + desconto);
                 }
            }
            public void deposito(decimal valor)
            {
                decimal taxa = 0.008;
                decimal desconto = valor * taxa;
                if (this.deposito >= 1000)
                {
                    this.saldo += (valor + desconto);
                } else 
                {
                    this.saldo += valor;
                }
            }
        }
}