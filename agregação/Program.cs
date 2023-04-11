namespace agregação;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação!");

        //Instanciando objeto0s de cada classe
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //Adicionando um nome para um cliente
        cli.Nome = "Kaike";

        //Adicionando numero e validade do cartão de crédito
        cdc.Numero = "123456789";
        cdc.DataValidade = "04/2033";

        //Assosiando ao atribuito de agregação em Cartão de Crédito
        cdc.Cliente = cli;

        //Visualizando as informações
        Console.WriteLine("Nome do cliente: " + cli.Nome);
        Console.WriteLine("Número do cartão: " + cdc.Numero);
        Console.WriteLine("Validade do cartão: " + cdc.DataValidade);
        Console.WriteLine("Nome do cliente AGREGADO: " + cdc.Cliente.Nome);
    }
}
