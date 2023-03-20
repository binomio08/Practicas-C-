// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int n1,n2, resultado;

//paso1:  pedir valores
Console.WriteLine("Ingrese un número:");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese otro número:");
n2 = int.Parse(Console.ReadLine()??"0");

//paso 2: realizar calculo.

resultado = n1 + n2;

//pasao 3: emitir resultado.

Console.WriteLine("El Resultado es:" + resultado);