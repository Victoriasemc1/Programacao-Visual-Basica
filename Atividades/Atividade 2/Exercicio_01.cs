
/* Elaborar o fluxograma e o programa que permita a entrada de um número pelo 
teclado e em seguida calcular a tabuada desse número
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Numero desejado:");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i<=10;i++){
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
        
    }
}