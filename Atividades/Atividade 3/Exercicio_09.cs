/*
Escreva um Programa que leia um valor inicial A e imprima a 
seqüência de valores do cálculo de A! e o seu resultado. 
Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120, usar a instrução while().
*/

using System;
class HelloWorld {
  static void Main() {
    int fat=1;
    Console.Write("Inicial:");
    int num = Convert.ToInt32(Console.ReadLine());
    
    while(num>0){
        fat *= num;
        Console.Write(num+" X ");
        num--;
        if(num<1){
            Console.Write("= "+fat);
        }
    }
  }
}
