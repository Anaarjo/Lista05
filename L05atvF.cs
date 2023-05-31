/*f)Calcule o valor absoluto de um número. */

using System;

class Program {
  public static void Main (string[] args) {
    //Variáveis
    int num, valorabs;
    // Entrada de dados
    Console.Write("Por favor, digite um número: ");
    num = int.Parse(Console.ReadLine());
    // Ternário
 valorabs = num < 0 ? -num : num;
Console.WriteLine("O valor absoluto de {0} é {1}. ", num, valorabs);
  }
}