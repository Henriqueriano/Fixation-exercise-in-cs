namespace ExercicioDois;
public class Init
{
    public static void Main(string[] args)
    {
        Processamento p = new Processamento();
        Console.Write("Enter the route: ");
        p.trajeto = Console.ReadLine()!;
        p.CalcularRota();
        Console.WriteLine(p.CalcularRota());
    }
}
