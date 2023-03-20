// Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.


//declaro variables

int n1, n2, resultado;

//Solicito datos para la suma

Console.WriteLine("Ingrese un número: ");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese un segundo número para la suma: ");
n2 = int.Parse(Console.ReadLine()??"0");


//Realizar calculo

resultado = n1 + n2;

//Mostrar resultado

Console.WriteLine("El resultado es:" + resultado);

