using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 3;
        Produto[] dados = new Produto[TAMANHO_VETOR];

        for (int i = 0; i < dados.Length; i++)
        {
            dados[i].id = int.Parse(Console.ReadLine());
            dados[i].nome = Console.ReadLine();
            dados[i].preco = double.Parse(Console.ReadLine());
            dados[i].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }

        for (int i = 0; i < dados.Length; i++)
        {
            if (dados[i].disponivelEmEstoque)
            {
                System.Console.WriteLine(dados[i].nome);
                System.Console.WriteLine(dados[i].preco);
            }
        }
    }
}
