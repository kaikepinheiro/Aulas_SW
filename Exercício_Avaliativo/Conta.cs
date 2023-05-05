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
            Console.WriteLine("Seu saque não foi liberado, pois você não tem esse dinheiro na conta!");
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
        
        double parcela = dinheiro/parcelas;
        double juros = dinheiro * 0.06;
        double parc_total = parcela + juros;
        double total = parc_total * parcelas;       

        string resultado = "Valor das Parcelas: "+ parcela +" Valor dos Juros: "+ juros + " Valor das parcelas com juros: "+ parc_total +" Valor total a se pagar: "+total;
        return resultado;
        
     
    }
    public void imprimi(string texto){
        Console.WriteLine(texto);
    }
}