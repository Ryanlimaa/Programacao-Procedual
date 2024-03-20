using System;

class program
{
  static void Main(string[] args)
  {
    int somatorio = 0;

    for (int contador = 1; contador >= 0; contador++)
    {
      System.Console.WriteLine("Digite um numero:");
      int numeroDigitado = int.Parse(Console.ReadLine());

      if (numeroDigitado % 2 == 1)
      {
        somatorio += numeroDigitado;
      }
      else if (numeroDigitado < 0)
      {
        break;
      }
    }
    Console.WriteLine("O somatorio de impares eh: " + somatorio);
  }
}
