namespace Exe02;
class ContratoPF: Contrato
{
    public string? cpf {get;set;}
    public string? idade {get;set;}

    public override string Base(){

        base.Base();

        Console.Write("Seu CPF: ");
        cpf = Console.ReadLine();

        Console.Write("Idade: ");
        idade = Console.ReadLine();
        
    }

}