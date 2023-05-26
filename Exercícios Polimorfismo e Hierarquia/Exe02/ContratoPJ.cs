namespace Exe02;
class ContratoPJ: Contrato
{
    public string? cnpj {get;set;}
    public string? IE {get;set;}
    public string? NE {get;set;}

    public override string Base(){

        base.Base();

        Console.WriteLine("Preencha os Campos com os dados da empresa!");
        Console.WriteLine("-------------------------------------------");

        Console.Write("CNPJ: ");
        cnpj = Console.ReadLine();

        Console.Write("IE: ");
        IE = Console.ReadLine();

        Console.Write("NE: ");
        NE = Console.ReadLine();

    }

}