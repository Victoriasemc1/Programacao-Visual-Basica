/*
Escreva um Programa que leia um valor inicial A e uma razão R e 
imprima uma seqüência em P.G. cont
*/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Inicio: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Razao: ");
    double r = Convert.ToDouble(Console.ReadLine());
    Console.Write("Número de termos: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    double termo = a;
    for (int i = 0; i < n; i++)
    {
        Console.Write(termo);
        termo *= r;
    }
  }
}
