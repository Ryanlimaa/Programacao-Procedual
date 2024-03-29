using System;

class Program
{
    static void Main(string[] args)
    {
        const int LINHAS = 3;
        const int COLUNAS = 3;
        int[,] numero = new int[LINHAS, COLUNAS];

        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                numero[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        numero[0, 2] = numero[0, 2] * 2;
        numero[1, 1] = numero[1, 1] * 2;
        numero[2, 0] = numero[2, 0] * 2;
        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                Console.Write(numero[linha, coluna] + "|");
            }
            System.Console.WriteLine();
        }
    }
}
