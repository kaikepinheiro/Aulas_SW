namespace Exe02;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Tel {get;set;}

    public virtual string Base(){

        Console.WriteLine("Preencha os Campos com os dados informados!");
        Console.WriteLine("-------------------------------------------");

        Console.Write("Seu Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Seu E-mail: ");
        Email = Console.ReadLine();

        Console.Write("Telefone: ");
        Tel = Console.ReadLine();

        string vazio = ("");
        return vazio;
    }

}