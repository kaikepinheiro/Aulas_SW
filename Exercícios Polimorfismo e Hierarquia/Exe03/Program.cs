namespace Exe03;
class Program
{
    static void Main(string[] args)
    {
        ContratoPJ cpj = new ContratoPJ();
        ContratoPF cpf = new ContratoPF();

        Console.WriteLine("Qual é seu tipo de pessoa?(Física ou Jurídica)");
        string metrica = Console.ReadLine();

        switch (metrica)
        {
            case "fisica":
                Console.WriteLine(fis.Base());
                Console.WriteLine("Sua parcela é de: " + fis.CalcularPrestacao());
                break;

            case "juridica":
                Console.WriteLine(jur.Base());
                Console.WriteLine("Sua parcela é de: " + jur.CalcularPrestacao());
                break;

            default:
                Console.WriteLine("Opção inválida, logo não é possivel calcular o valor da parcela.");
                break;
        }


    }
}
