namespace Exercício_Avaliativo;
class Conta
{   
    //Banco
    public int Numero {get; set;}
    private double Saldo { get;  set;}
    public double Limite {get; private set;}

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }
    public void Depositar( double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if (this.Saldo + this.Limite <= valor){
            Console.WriteLine("Você esta sacando mais do que você tem");
        }else{
             this.Saldo -= valor;
        }
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }

    //Empréstimo
    public double parcela {get; set;}
    public double valor {get; set;}

    public string emprestimo(int parcelas, double dinheiro){
        this.parcela = parcelas;
        this.valor = dinheiro;
        
        double juros = dinheiro/parcelas;
        double mult = dinheiro * 0.06;
        double soma = mult + juros;
        double total = soma * parcelas;       

        string resultado = "O valor da sua parcela sem juros é: "+ juros +". O valor da parcela com juros: "+ mult + ". O valor do juros com prestações é de: "+ soma +"e o valor total a pagar é de: "+total;
        return resultado;
        
     
    }
    public void imprimi(string texto){
        Console.WriteLine(texto);
    }
}