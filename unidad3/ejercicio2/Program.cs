// See https://aka.ms/new-console-template for more information


//Hacer un programa para ingresar un número 
//luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

// Declaramos Variables
int n;


// Solicitamos Datos

Console.WriteLine("Ingrese un número al azar");
n = int.Parse(Console.ReadLine()??"0");

// Declaramos Condicionales

if(n > 0)
    Console.WriteLine("Positivo");
else if(n<0)
    Console.WriteLine("Negativo");
else if(n == 0)
    Console.WriteLine("Cero");


Console.WriteLine("Fin del Programa");

