using System;
using System.Net.Http.Headers;

class Program
{
    public static void Main (string[] args)
    {
    
    Console.WriteLine("Digite a nota da diciplina Portugues do aluno Ryan de Lima Rodrigues Leite:");
    double Portugues = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da diciplina Matematica do aluno Ryan de Lima Rodrigues Leite:");
    double Matematica = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da diciplina Historias do aluno Ryan de Lima Rodrigues Leite:");
    double Historias = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da diciplina Fisica do aluno Ryan de Lima Rodrigurs Leite:");
    double Fisica = double.Parse(Console.ReadLine());

    Console.WriteLine("Calcule a media do aluno digitando (sim):");
    string sim = Console.ReadLine();

    double media = (Portugues + Matematica + Historias + Fisica) / 4.0;

    Console.WriteLine("A media do aluno é de: " + media);

    }
}
