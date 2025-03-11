
/* Desenvolver um programa que efetue a soma de todos os números 
ímpares que são múltiplos de três e que se encontram no conjunto 
dos números de 1 até 500.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int tot = 0;
        for(int i = 1;i<=500;i++){
            if((i%2!=0) && (i%3==0)) {
                tot += i;
            }
        }
        Console.Write(tot);
    }
}