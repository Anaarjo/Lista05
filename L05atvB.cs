/*b) Encontre o maior entre dois números. */
using System;

class Program {
  public static void Main (string[] args) {
    // Variáveis
   double n1,n2;
    string resposta;
    // Entrada de dados
    Console.Write("Por favor, digite o 1º número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
  Console.Write("Por favor, digite o 2º número: ");
    n2 = Convert.ToDouble(Console.ReadLine());
    // Ternário
    resposta = n1 > n2 ? "maior": "menor" ;
    
Console.WriteLine("O número {0} é {1} que o número {2}", n1, resposta, n2);
  }
}