using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 12;
        int[] pesoDigitado = new int[TAMANHO_VETOR];

        PreencherVetor(pesoDigitado);

        ValidePeso(pesoDigitado);
    }

    static void PreencherVetor(int[] vetor)
    {
        for (int i = 1; i < vetor.GetLength(0); i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static void ValidePeso(int[] vetor)
    {
        for (int i = 1; i < vetor.GetLength(0); i++)
        {
            if (vetor[i] > 50)
            {
                System.Console.WriteLine(i + "° vagao ultrapassou o limite de peso");
            }
        }
    }
}
