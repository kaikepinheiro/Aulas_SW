namespace Exe03;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Tel {get;set;}
    public int meses {get;set;}
    public decimal valor {get;set;}
    public decimal Prestacao {get;set;}

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

    public virtual decimal CalcularPrestacao(){

        Console.WriteLine("Prestação");
        Console.WriteLine("---------");
        
        Console.Write("Valor: ");
        valor = int.Parse(Console.ReadLine());

        Console.Write("Meses: ");
        meses = int.Parse(Console.ReadLine());

       decimal Prestacao = valor/meses;
       return Prestacao;
    }

}