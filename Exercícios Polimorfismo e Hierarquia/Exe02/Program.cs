namespace Exe02;
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
            case "física":
                Console.WriteLine(fis.Base());
                break;

            case "juridica":
                Console.WriteLine(jur.Base());
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
