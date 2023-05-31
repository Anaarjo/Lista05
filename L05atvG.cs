/*g) Verifique se um número é positivo, negativo ou zero. */
using System;

class Program {
  public static void Main (string[] args) {
    // Var
    double n1;
    string calculo;
    // Entrada de dados
    Console.Write("Por favor digite um número: ");
    n1= Convert.ToDouble(Console.ReadLine());
    calculo = (n1 > 0) ? "positivo" : (n1 < 0) ? "negativo" : "zero";
    Console.Write("O número é {0} é {1}.",n1, calculo);
  }
}