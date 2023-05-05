namespace Exercício_Avaliativo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Banco ETEC MCM");
        Conta c = new Conta();
        //c.Saldo = 1000;
        c.Depositar(1000);
        c.Sacar(1600);
        c.AjustarLimite(500);

        double valortotal = c.MostrarSaldo();

        Console.WriteLine("Seu saldo total é de " + valortotal);

        c.imprimi(c.emprestimo(12,1000));
    }
}
