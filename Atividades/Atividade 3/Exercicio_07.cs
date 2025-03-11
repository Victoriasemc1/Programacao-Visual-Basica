/******************************************************************************
Escreva um Programa que leia um valor inicial A e uma razão R e 
imprima uma seqüência em P.A. contendo 10 valores.
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Inicio:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Razao:");
    int r = Convert.ToInt32(Console.ReadLine());
    
    for(int i=0;i<3;i++){
        int aux = a+i*r;
        Console.WriteLine(aux);
    }
  }
}
