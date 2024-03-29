using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int[] numeros = new int[10];

        while (contador < 10)
        {
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado >= 10 && numeroDigitado <= 50)
            {
                numeros[contador] += numeroDigitado;
                contador++;
            }
        }
        System.Console.WriteLine();
        for (contador = 0; contador < 10; contador++)
        {
            System.Console.WriteLine(numeros[contador]);
        }
    }
}
