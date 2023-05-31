/*e) Verifique se uma condição é verdadeira.*/
using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("Digite 'true' ou 'false':");
string entrada = Console.ReadLine();
bool valorBool = bool.Parse(entrada);
string resultado = valorBool ? "Verdadeiro" : "Falso";
Console.WriteLine(resultado);
  }
}