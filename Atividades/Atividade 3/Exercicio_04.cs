/*
Escrever um Programa que leia uma quantidade desconhecida de 
números e conte quantos deles estão nos seguintes intervalos:
[0-25], [26-50], [51-75] e [76-100]. A entrada de dados deve 
terminar quando for lido um número negativo.
*/

using System;
class HelloWorld {
  static void Main() {
    int intervalo1 = 0;
    int intervalo2 = 0;
    int intervalo3 = 0;
    int intervalo4 = 0;
    while(true){
        Console.Write("Numero:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0 && num <= 25)
                intervalo1++;
            else if (num >= 26 && num <= 50)
                intervalo2++;
            else if (num >= 51 && num <= 75)
                intervalo3++;
            else if (num >= 76 && num <= 100)
                intervalo4++;
        
        if(num <0){
            break;
        }       
    }
    Console.WriteLine("Números no intervalo [0-25]:"+intervalo1);
    Console.WriteLine("Números no intervalo [26-50]:"+ intervalo2);
    Console.WriteLine("Números no intervalo [51-75]:"+intervalo3);
    Console.WriteLine("Números no intervalo [76-100]:"+ intervalo4);
  }
}
