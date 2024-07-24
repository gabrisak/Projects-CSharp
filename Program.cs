using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira as amostras separadas por vírgula (ex: 50, 50, 70, 80, 100):");
        string input = Console.ReadLine();

        string[] valores = input.Split(',');
        int[] amostras = new int[valores.Length];

        for (int i = 0; i < valores.Length; i++)
        {
            amostras[i] = Convert.ToInt32(valores[i].Trim());
        }

        double media = CalculaMedia(amostras);
        int acimaDaMedia = ContaAcimaDaMedia(amostras, media);
        double percentualAcimaDaMedia = (double)acimaDaMedia / amostras.Length * 100;

        Console.WriteLine($"Média das amostras: {media:F2}");
        Console.WriteLine($"Número de alunos acima da média: {acimaDaMedia}");
        Console.WriteLine($"Percentual de alunos acima da média: {percentualAcimaDaMedia:F2}%");
    }

    static double CalculaMedia(int[] amostras)
    {
        double soma = 0;
        foreach (int amostra in amostras)
        {
            soma += amostra;
        }
        return soma / amostras.Length;
    }
    static int ContaAcimaDaMedia(int[] amostras, double media)
    {
        int count = 0;
        foreach (int amostra in amostras)
        {
            if (amostra > media)
            {
                count++;
            }
        }
        return count;
    }
}
