namespace ex_aviao;
class Aviao
{
    public string tipo = "";
    public int agencia;
    public int conta;
    public decimal valor;

    private void sacar(){
        valor--;
    }

     private void transferir(){
        valor--;
        valor++;
    }

     private void consultar(){
        conta--;
    }

     private void depositar(){
        valor++;
    }
    }
