/*
Escrever um programa que dados um número N, determinar a sequência 
de Fibonacci desse número (1,1,2,3,5,8,13.........n-1 + n).
*/

using System;
class HelloWorld {
  static void Main() {
    int aux;
    int t1=1;
    int t2=1;
    Console.Write("Numero:");
    int num = Convert.ToInt32(Console.ReadLine());
    
    Console.Write(t1 + " " + t2 + " ");
    for(int i=0;i<num;i++){
        aux=t2+t1;
        Console.Write(aux + " ");
        t1 =t2;
        t2 = aux;
    }
  }
}
