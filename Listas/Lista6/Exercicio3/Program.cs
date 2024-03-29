using System;

class Program
{
    static void Main(string[] args)
    {
        const int LINHAS = 3;
        const int COLUNAS = 3;
        int somatorio = 0;
        int[,] numero = new int[LINHAS, COLUNAS];

        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                numero[linha, coluna] = int.Parse(Console.ReadLine());
                if (linha == coluna)
                {
                    somatorio += numero[linha, coluna];
                }
            }
        }
        System.Console.WriteLine(somatorio);
    }
}
