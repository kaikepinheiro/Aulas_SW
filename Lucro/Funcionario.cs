namespace Lucro;

class Funcionario
{
    public string? Nome{get;set;}
    public int Idade;
    public virtual double Lucro(){
        return 12000;
    }
}