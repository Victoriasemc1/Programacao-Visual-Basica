/*
Faça um Programa estruturado que leia uma quantidade não determinada
de números positivos. Calcule a quantidade de números pares e 
ímpares, a média de valores pares e a média geral dos números lidos.
O número que encerrará a leitura será zero.
*/

using System;
class HelloWorld {
  static void Main() {
    double media_pares = 0;
    int pares = 0;
    int impares = 0;
    int soma = 0;
    int somaTotal = 0;
    int cont = 0;
    while(true){
        Console.Write("Numero:");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if(num<0){
            Console.Write("Apenas numeros positivos");
            continue;
        }
        
        if(num == 0){
            break;
        }
        
        cont++;
        somaTotal += num;
        if(num%2==0){
            pares++;
            soma += num;
            media_pares = soma/pares;
        }else{
            impares++;
        }
            
    }
    double media = somaTotal/cont;
    Console.WriteLine("Pares:"+pares);
    Console.WriteLine("Impares:"+impares);
    Console.WriteLine("Media:"+ media);
    Console.WriteLine("Media dos pares:"+ media_pares);
  }
}

