using System;
using System.Runtime.ConstrainedExecution;

class program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite o tamanho da base do retangulo:");
        int baseretangulo = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite o tamanho da altura do retangulo:");
        int alturaretangulo = int.Parse(Console.ReadLine());

        for (int linha = 0; linha < baseretangulo; linha++)
        {
            for (int coluna = 0; coluna < alturaretangulo; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}
