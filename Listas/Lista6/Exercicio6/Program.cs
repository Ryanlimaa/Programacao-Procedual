using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        const int LINHAS = 4;
        const int COLUNAS = 4;
        int somatorio = 0;
        int[,] numero = new int[LINHAS, COLUNAS];

        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                numero[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        int opcao = int.Parse(Console.ReadLine());

        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                if (opcao == 1)
                {
                    Console.WriteLine(numero[linha, coluna]);
                }
                else if (opcao == 2)
                {
                    somatorio += numero[linha, coluna];
                }
                else if (opcao == 4)
                {
                    if (linha == coluna)
                    {
                        somatorio += numero[linha, coluna];
                    }
                }
            }
        }
        if (opcao == 3)
        {
            System.Console.WriteLine(numero[0, 2] = numero[2, 1] = numero[2, 2] = numero[3, 2]
            * 4);
        }
        else if (opcao == 5)
        {
            System.Console.WriteLine(numero[0, 1] = numero[2, 1]);
        }
        System.Console.WriteLine(somatorio);
    }
}
