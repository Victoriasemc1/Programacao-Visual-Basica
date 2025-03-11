
/* Codifique em C# o fluxograma apresentado e comente qual atividade
que o programa realizará?
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Numero desejado:");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n%2 ==0){
            Console.Write("Numero par");
        }else{
            Console.Write("Numero impar");
        }
    }
}