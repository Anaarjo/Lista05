/*a) Verifique se um número é par ou ímpar.*/
using System;

class Program {
  public static void Main (string[] args) {
    // Variáveis
    int n1;
    string resposta;
    //Entrada de dados
    Console.Write("Por favor digite um número: ");
 n1 = Convert.ToInt32(Console.ReadLine());
// Ternário condições 
resposta = n1 % 2 == 0 ?  "par": "ímpar";
Console.WriteLine("O número {0} é {1}.", n1, resposta);
  }
}