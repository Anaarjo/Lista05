/*d) Verifique se uma string está vazia.*/
using System;

class Program {
  public static void Main (string[] args) {
     // Variáveis
    string palavra, resposta;
    //Entrada de dados
    Console.Write("Por favor, digite uma palavra: ");
    palavra = Console.ReadLine();
    // Saída
  resposta = string.IsNullOrEmpty(palavra) ? "vazia" : "não vazia";
    Console.Write("A string está {0}.", resposta);
    }
}