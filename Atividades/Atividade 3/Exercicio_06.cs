/*
Escrever um Programa que gera e escreve os números ímpares entre 100
e 200.
*/

using System;
class HelloWorld {
  static void Main() {
    
    for(int i = 100; i<=200;i++){
        if(i%2!=0){
            Console.WriteLine(i);
        }
    }
    
  }
}

