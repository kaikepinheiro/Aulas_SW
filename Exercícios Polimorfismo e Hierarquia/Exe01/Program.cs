namespace Exe01;
class Program
{
    static void Main(string[] args)
    {
        Cao maya = new Cao();
        Gato tico = new Gato();
        Homem Kaike = new Homem();

        Console.WriteLine("O cão " + maya.Fala());
        Console.WriteLine("O gato " + tico.Fala());
        Console.WriteLine("O homem " + Kaike.Fala());

    }
}
