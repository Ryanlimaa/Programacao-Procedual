using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador1 = 1; contador1 <= 10;contador1++)
        {
            for (int contador2 = 1; contador2 <= 10; contador2++)
            {
                System.Console.WriteLine($"{contador1} X {contador2} = {contador1 * contador2}");
            }
            System.Console.WriteLine();
        }
    }
}