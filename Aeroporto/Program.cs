namespace Aeroporto;
class Program
{
    static void Main(string[] args)
    {
        Aeroporto a1 = new Aeroporto();
        a1.AlteraCodigo(1);
        a1.AlteraNome("MCM Airlines");
        a1.AlteraEntrada("São Paulo");
        a1.AlteraSaida("Orlando");
        a1.MostraDados();

    }
}
