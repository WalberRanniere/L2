using System;

public class Questao4 {
  public static void Main (string[] args) {

    Console.WriteLine("Digite a base e a altura do retângulo");

    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());

    double area = b*h;
    double peri = b*2+h*2;
    double diag = Math.Sqrt(b*b + h*h);

    Console.WriteLine($"Área = {area:f2} - Perímetro = {peri:f2} - Diagonal = {diag:f2}");
    
  }
}