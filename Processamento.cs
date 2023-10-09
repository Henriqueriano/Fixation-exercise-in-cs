namespace ExercicioDois;
public class Processamento
{
    public int[,] tabela { get; set; } = {  {   0,  63, 210, 190,  0, 190},
                                            {  63,   0, 160, 150, 95,  0 },
                                            { 210, 160,   0,  10,  0,  0 },
                                            { 190, 150,  10,   0,  0,  0 },
                                            {   0,  95,   0,   0,  0,  80 },
                                            { 190,   0,   0,   0, 80,  0 }};
    public string? trajeto { get; set; }


    public int CalcularRota()
    {
        int[] rota;
        int soma = 0;
        string[] localVar = trajeto!.Split(",");
        rota = new int[localVar.Length];

        for (int i = 0; i < rota.Length; i++)
        {
            rota![i] = int.Parse(localVar[i]) - 1;
        }

        for (int i = 0; i < rota.Length - 1; i++)
        {
            soma += tabela[rota[i], rota[i + 1]];
        }
        return soma;

    }

}


