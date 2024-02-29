using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota do auluno:");
        double notaDoAluno1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota do auluno:");
        double notaDoAluno2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota do auluno:");
        double notaDoAluno3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota do auluno:");
        double notaDoAluno4 = double.Parse(Console.ReadLine());

        double media = (notaDoAluno1 + notaDoAluno2 + notaDoAluno3 + notaDoAluno4) / 4.0;

        if (media >= 5.0)
         {
            Console.WriteLine("Aluno aprovado!");
         }
         else if (media < 5.0 && media >= 3.0)
         {
            Console.WriteLine("aluno em recuperacao!");
         }
         else if (media < 3.0)
         {
            Console.WriteLine("Aluno reprovado.");
         }
        
    }
}

