using System;

class Program
{
    static void  Main(string[] args)
    {
        const int NUMERO_MAXIMO = 1;
        const int NUMERO_MINIMO = 9;

        System.Console.WriteLine("Digite um numero:");
        int tamanhoQuadrado = int.Parse(Console.ReadLine());

        if (tamanhoQuadrado < NUMERO_MINIMO || tamanhoQuadrado > NUMERO_MAXIMO)
        {
            System.Console.WriteLine("altura invalida, insira uma altura entre 1 e 9");
        }
        else
        {
            for (int linha = 0; linha <= tamanhoQuadrado; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    System.Console.Write(coluna);
                }
                System.Console.WriteLine();
            }
        }
    }
}