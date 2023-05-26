namespace Exe03;
class ContratoPF: Contrato
{
    public string? cpf {get;set;}
    public int idade {get;set;}

    public override string Base(){

        base.Base();

        Console.Write("Seu CPF: ");
        cpf = Console.ReadLine();

        Console.Write("Idade: ");
        idade = Console.ReadLine();
        
    }

    public override decimal CalcularPrestacao(){

        if(idade <= 30){
            return (base.CalcularPrestacao()+1);
        }else 
        
        if(idade <=40){
            return (base.CalcularPrestacao()+2);
        }else 
        
        if(idade <=50){
            return (base.CalcularPrestacao()+3);
        }
        
        else{
            return (base.CalcularPrestacao()+4);
        }
    }


}