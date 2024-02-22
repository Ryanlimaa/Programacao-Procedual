using System;

class Program
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("Para calcular a area de um triangulo, deve-se antes de tudo informar sua base e sua altura, informe o valor equivalente a base do triangulo:");
    double baseTriangulo = double.Parse(Console.ReadLine());

    Console.WriteLine("Agora informe o valor equivalente a altura do triangulo:");
    double alturaTriangulo = double.Parse(Console.ReadLine());

    double area = (baseTriangulo * alturaTriangulo) / 2;

        bool resultado = area > 20;

        Console.WriteLine("A area do triangulo é maior que 20? " + resultado );
  }
    
}
