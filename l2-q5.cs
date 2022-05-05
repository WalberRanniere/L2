using System;

public class Program {
  public static void Main(string[] args){
    Console.WriteLine("Digite o intervalo de de tempo no formato \"HH:MM:SS\"");
    string tudo = Console.ReadLine();
    string[] valores = tudo.Split(':');

    double segundos = double.Parse(valores[2]);
    Console.WriteLine(segundos);
    
    double minutos = 60*(double.Parse(valores[1]));
    Console.WriteLine(minutos);
    
    double horas = 3600*(double.Parse(valores[0]));
    Console.WriteLine(horas);
    

    double total = segundos+minutos+horas;
    Console.WriteLine(total);

    double dist = total*300000;
    Console.WriteLine(dist);
    

    Console.WriteLine("A luz percorreu {0} km nesse intervalo", dist);
    
    
  }
}