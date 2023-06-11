// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    { 
        Console.WriteLine("Ingrese altura en metros");
        double altura =  float.Parse( Console.ReadLine());
        Console.WriteLine("Ingrese peso en kilogramos");
        double peso =  float.Parse( Console.ReadLine());
        
        double indice = peso / (altura*altura);
        indice = Math.Round(indice, 1, MidpointRounding.AwayFromZero);
        string categoria = "";
        if (indice <= 18.4){
            categoria = "Insuficiencia Ponderal";
        }else if(indice <= 24.9){
            categoria = "Normal";
        }else if(indice <= 29.9){
            categoria = "Sobrepeso";
        }else if(indice <= 34.9){
            categoria = "Obesidad I";
        }else if (indice <= 39.9){
            categoria = "Obesidad II";
        }else{
            categoria = "Obesidad III";
        }
        Console.WriteLine($"Estas en la categoria {categoria}");
}
}
