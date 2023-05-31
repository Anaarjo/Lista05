
using System;

class Program {
  public static void Main (string[] args) {
    //
    Console.Write("Por favor, digte um número: ");
    string str = Console.ReadLine();
int num = int.TryParse(str, out int result) ? result : 0;
Console.WriteLine($"O número é {num}.");
  }
}