// See https://aka.ms/new-console-template for more information

//Hacer un programa para ingresar un número 
//luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

// Declaramos Variables
int n;


Console.WriteLine("Ingrasa el primer número que se cruce por tu mente");
n = int.Parse(Console.ReadLine()??"0");

if(n > 10)
    Console.WriteLine("Es Mayor a 10"); 
    else
    Console.WriteLine("Es menor a 10");


Console.WriteLine("Fin del Programa");