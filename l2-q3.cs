using System;

public class Progr {
  public static void Main (string[] args){

    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");

    int nota1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");

    int nota2 = int.Parse(Console.ReadLine());

    int result = (nota1*2+nota2*3)/5;
    Console.WriteLine("Media Parcial = {0}", result);
   
  }
}