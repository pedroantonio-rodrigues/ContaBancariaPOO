using System; 

namespace Banco
{
   public class Program
    {
        static void Main(string[] args){
        
            contaBancaria conta1 = new contaBancaria("MARIA JOANA", 789.99, "123456", "PF", 3);
            
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Criando Conta");
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Conta: " + conta1.NumeroConta);
            Console.Out.WriteLine("Titular: " + conta1.Nome);
            Console.Out.WriteLine("Tipo: " + conta1.TipoConta);
            Console.Out.WriteLine("Saldo: " + conta1.saldo);

            conta1.Depositar(100.00);
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Depositando");
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Conta: " + conta1.NumeroConta);
            Console.Out.WriteLine("Titular: " + conta1.Nome);
            Console.Out.WriteLine("Tipo: " + conta1.TipoConta);
            Console.Out.WriteLine("Saldo: " + conta1.saldo);

            conta1.Saque(500.00);
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("primeiro saque");
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Conta: " + conta1.NumeroConta);
            Console.Out.WriteLine("Titular: " + conta1.Nome);
            Console.Out.WriteLine("Tipo: " + conta1.TipoConta);
            Console.Out.WriteLine("Saldo: " + conta1.saldo);

            conta1.Saque(500.00);
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("segundo saque");
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Conta: " + conta1.NumeroConta);
            Console.Out.WriteLine("Titular: " + conta1.Nome);
            Console.Out.WriteLine("Tipo: " + conta1.TipoConta);
            Console.Out.WriteLine("Saldo: " + conta1.saldo);

            conta1.Saque(500.00);
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("terceiro saque");
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Conta: " + conta1.NumeroConta);
            Console.Out.WriteLine("Titular: " + conta1.Nome);
            Console.Out.WriteLine("Tipo: " + conta1.TipoConta);
            Console.Out.WriteLine("Saldo: " + conta1.saldo);

            conta1.Saque(500.00);
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("quarto saque");
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Conta: " + conta1.NumeroConta);
            Console.Out.WriteLine("Titular: " + conta1.Nome);
            Console.Out.WriteLine("Tipo: " + conta1.TipoConta);
            Console.Out.WriteLine("Saldo: " + conta1.saldo);
        }
    }
}
