namespace Banco
{
    public class contaBancaria
    {
        public string Nome;
        public decimal saldo;
        public string NumeroConta;
        public string TipoConta;
        public int saques;

        public contaBancaria(string nomeUsuario, decimal saldo, string numeroConta, string tipoConta, int saques)
        {
            this.Nome = nomeUsuario;
            this.saldo = saldo;
            this.NumeroConta = numeroConta;
            this.TipoConta = tipoConta;
            this.saques = 3;
        }

        public void saque(decimal valor)
        {
            this.saldo -= valor;
        }

        public void depositar(decimal valor)
        {
            this.saldo += valor;
        }
    }
}
