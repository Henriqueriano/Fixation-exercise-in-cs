namespace ExercicioDois;
public class Init
{
    public static void Main(string[] args)
    {
        Processamento p = new Processamento();
        Console.Write("Informe o trajeto: ");
        p.trajeto = Console.ReadLine()!;
        p.CalcularRota();
        Console.WriteLine(p.CalcularRota());
    }
}