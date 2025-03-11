
/*O fluxograma apresentado realiza a tarefa de capturar do teclado a base e altura
para um triângulo e calcular a área correspondente, codificar em linguagem C# e 
testar o programa.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double b, h;
        Console.Write("Base: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Altura: ");
        h = Convert.ToDouble(Console.ReadLine());

        double S = (b * h) / 2;
        Console.WriteLine(S);
    }
}