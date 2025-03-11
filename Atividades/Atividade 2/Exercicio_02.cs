
/* Uma progressão aritmética (P.A.) é uma sequência de números em que
cada termo da sequência, a partir do segundo, é igual à soma do termo
anterior com uma constante r, denominada razão.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Numero desejado:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Termo inicial:");
        double inicial = Convert.ToDouble(Console.ReadLine());
        Console.Write("Razao:");
        double razao = Convert.ToDouble(Console.ReadLine());
        Console.Write(inicial+",");
        for(int i = 1; i <=n-1;i++){
            double aux = inicial+ razao;
            inicial = aux;
            if(i==n-1){
                Console.Write(aux);
            }else{
                Console.Write(aux+",");
            }
        }
    }
}