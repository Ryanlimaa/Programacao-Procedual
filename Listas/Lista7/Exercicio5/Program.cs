using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencherMatriz(matriz);

        if (ValideMatriz(matriz))
        {
            System.Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
        else
        {
            System.Console.WriteLine("Nao ha balistas no tabuleiro");
        }
    }

    static void PreencherMatriz(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
    }

    static bool ValideMatriz(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                if (matriz[linha, coluna] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
