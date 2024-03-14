using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <= 10; contador++)
        {
            for (int contador2 = 1; contador2 <= 10; contador2++)
            {
                System.Console.WriteLine($"{contador} X {contador2} = {contador * contador2}");
            }
            System.Console.WriteLine();
        }
    }
}