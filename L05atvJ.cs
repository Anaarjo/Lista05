/* j) Verifique se uma variável é nula ou não.*/
using System;

class Program {
  public static void Main (string[] args) {
    int? x = null;
    // define a variável x como nula
string mensagem = x == null ? "x é nulo" : "x não é nulo"; // verifica se x é nulo usando operador ternário

Console.WriteLine(mensagem); 
  }
}