
/* Desenvolver um Programa que leia a altura de 15 pessoas. Este 
programa deverá calcular e mostrar : a. A menor altura do grupo;
b. A maior altura do grupo;
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double maior = 0;
        double menor = 0;
        for(int i = 1;i<=3;i++){
            Console.Write(i+"° Altura:");
            double a = Convert.ToDouble(Console.ReadLine());
            if(a> maior){
                maior = a;
            }
            if((a < menor) || (menor == 0)){
                menor = a;
            }
        }
        Console.Write("Maior "+maior);
        Console.Write(" Menor "+menor);
    }
}