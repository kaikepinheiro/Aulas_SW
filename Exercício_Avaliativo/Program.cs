namespace Exercício_Avaliativo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM VINDO AO BANCO DOS CRIAS");
{
    static void Main(string[] args){

        Conta c = new Conta();

        c.Depositar(500);
        c.Sacar(900);
        c.Sacar(1000);

        Console.Write("Digite o valor do seu emprestimo: ");
        c.valor = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Seu emprestimo é de: " + c.valor);
        Console.WriteLine("Seu emprestimo com Juros é de: " + c.total());
        Console.WriteLine("Suas parcelas mensais serão de: " + c.juros());

    }
}
    }
}
