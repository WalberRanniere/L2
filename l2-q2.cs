using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite seu nome completo");

    string nome = Console.ReadLine();
    string[] palavras = nome.Split(' ');
    string primeiro_nome = palavras[0];

    Console.WriteLine("Bem vindo ao C#, " + primeiro_nome);
  }
}