using System;

public class Program {
  public static void Main(string[] args){
    Console.WriteLine("Digite o intervalo de de tempo no formato \"HH:MM:SS\"");
    string tudo = Console.ReadLine();
    string[] valores = tudo.Split(':');

    int segundos = int.Parse(valores[2]);
    Console.WriteLine(segundos);
    
    int minutos = 60*(int.Parse(valores[1]));
    Console.WriteLine(minutos);
    
    int horas = 3600*(int.Parse(valores[0]));
    Console.WriteLine(horas);
    

    int total = segundos+minutos+horas;
    Console.WriteLine(total);

    int dist = total*300000;
    Console.WriteLine(dist);
    

    Console.WriteLine("A luz percorreu {0} km nesse intervalo", dist);
    
    
  }
}