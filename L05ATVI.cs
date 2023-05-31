using System;

class Program {
  public static void Main (string[] args) {
   //Var
int n1,n2;
string calculo;
// Entrada de dados 
Console.Write("Por favor, digite o 1° número: " );
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Por favor, digite o 2 ° número: " );
n2 = Convert.ToInt32(Console.ReadLine());
// Saída de dados e o cálculo
calculo = n1 % n2 == 0 ? "é" : "não";
Console.WriteLine("O número {0} {1} divisível por {2}.", n1, calculo, n2);

  }
}