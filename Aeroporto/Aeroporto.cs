
namespace Aeroporto;
class Aeroporto
{   

     public Aeroporto(int codigo, string nome)
    {
        this.Codigo = codigo;
        this.Nome = nome;
        this.Entrada = "Não informado";
        this.Saida = "Não informado";
        
    }

    public Aeroporto(int codigo, string nome, string entrada, string saida)
    {
        this.Codigo = codigo;
        this.Nome = nome;
        this.Entrada = entrada;
        this.Saida = saida;
        
    }

    public Aeroporto()
    {
    }

    private int Codigo {get; set;}
     private string? Nome {get; set;}
     private string? Entrada {get; set;}
     private string? Saida {get; set;}

      public void AlteraCodigo(int codigo){
        this.Codigo = codigo;
    }

    public void AlteraNome(string nome){
        this.Nome = nome;
    }

    public void AlteraEntrada(string entrada){
        this.Entrada = entrada;
    }

    public void AlteraSaida(string saida){
        this.Saida = saida;
    }

  public void MostraDados(){
        Console.WriteLine("Código: " + this.Codigo);
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Entrada: " + this.Entrada);
        Console.WriteLine("Saída: " + this.Saida);

    }

}