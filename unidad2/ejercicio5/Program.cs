// See https://aka.ms/new-console-template for more information
// Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
//  calcule y emita por pantalla el promedio final.

// Declaramos Variables

float nota1, nota2 , nota3, promedio;

// Solicitamos valores

Console.WriteLine("Ingrese la nota del Primer trimestre");
nota1 = float.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese la nota del Segundo trimentre");
nota2 = float.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese la nota del tercer Trimestre");
nota3 = float.Parse(Console.ReadLine()??"0");

// Sacamos Prmedio

promedio = (nota1 + nota2 + nota3 ) / 3;

// Mostramos resultados

Console.WriteLine("El promedio de notas es: " + promedio.ToString("0.00"));