using System;


struct Pizza
{
    public int id;
    public string sabor;
    public double preco;
}
class Program
{
    static void Main(string[] args)
    {
        Pizza pizza;

        pizza.id = int.Parse(Console.ReadLine());
        pizza.sabor = Console.ReadLine();
        pizza.preco = double.Parse(Console.ReadLine());

        System.Console.WriteLine(pizza.id);
        System.Console.WriteLine(pizza.sabor);
        System.Console.WriteLine(pizza.preco);
    }
}
