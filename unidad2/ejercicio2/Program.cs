// Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.


//Delcaro variables 

int n1 , resultado;

//solicito datos al usuario

Console.WriteLine("Indique el número que quiere eleba al cubo");
n1 = int.Parse(Console.ReadLine()??"0");

//El programa resuelve

resultado = n1*n1*n1;

//muestro resultado

Console.WriteLine("El Resultado es:" + resultado);