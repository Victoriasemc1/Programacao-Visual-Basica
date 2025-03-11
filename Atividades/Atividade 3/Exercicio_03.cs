
/* Desenvolver um Programa que leia um número não determinado de 
valores e calcule e escreva a média aritmética dos valores lidos,
a quantidade de valores positivos, a quantidade de valores negativos
e o percentual de valores negativos e positivos.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double soma=0;
        double media =0;
        double cont = 0;
        int negativos=0; 
        int positivos =0;
        
        while (true) {
            cont++;
            Console.Write("Numero:");
            double num = Convert.ToDouble(Console.ReadLine());
            
            soma += num;
            media = soma/cont;
            
            if(num > 0){
                positivos++;
            }else{
                negativos++;
            }
            
            double perc_positivos = (double)positivos / cont * 100;
            double perc_negativos = (double)negativos / cont * 100;
            Console.Write("Dejesa continuar(S/N)?");
            string resp = Console.ReadLine();
            
            if(resp == "n" || resp =="nao"){
                Console.WriteLine("Soma: " + soma);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("Quantidade de positivos: " + positivos);
                Console.WriteLine("Quantidade de negativos: " + negativos);
                Console.WriteLine("Percentual de positivos: " + perc_positivos+ "%");
                Console.WriteLine("Percentual de negativos: " + perc_negativos+ "%");
                break;
            }
        }
    }
}