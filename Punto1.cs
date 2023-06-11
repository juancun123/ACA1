// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    { 
        Console.WriteLine("Ingrese salario mensual");
        int salario =  int.Parse( Console.ReadLine());
        Console.WriteLine("Ingrese numero de horas extras trabajadas");
        int cantidadHorasExtras =  int.Parse( Console.ReadLine());
        float valorHora = salario/240F;
        Console.WriteLine("Valor por hora = "+valorHora.ToString());
        float valorAdicional = 0F;
        float valorHoraExtra = 0;
        switch (cantidadHorasExtras){
            case <=40:
                 valorHoraExtra = valorHora + (valorHora* 0.125F);
                Console.WriteLine("Valor por hora extra = "+valorHoraExtra.ToString());
                valorAdicional = valorHoraExtra * cantidadHorasExtras;
            break;
            case >40:
                valorHoraExtra = valorHora + (valorHora* 0.15F);
                valorAdicional =  valorHoraExtra * 30;
                Console.WriteLine("Valor por hora extra (primeras 30 horas)= "+valorHoraExtra.ToString());
                int restante = cantidadHorasExtras - 30;
                valorHoraExtra = valorHora + (valorHora  * 0.2F);
                Console.WriteLine($"Valor por hora extra ({restante} horas restantes)= {valorHoraExtra.ToString()}");
                valorAdicional += valorHora * restante;
             break;
        }
        float salarioFinal = salario + valorAdicional;
        
        Console.WriteLine("Adicional por horas extras trabajadas = " + valorAdicional.ToString());
        Console.WriteLine("Salario final = " + salarioFinal.ToString());
    }
}
