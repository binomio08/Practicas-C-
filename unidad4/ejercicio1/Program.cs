// See https://aka.ms/new-console-template for more information

//Hacer un programa que solicite el ingreso de dos números y luego calcular:

    //La resta si el primero es mayor que el segundo.
    //La suma si son iguales.
    //El producto si el primero es menor.
    //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

//Declaramos variables

int n1, n2, resultado;

// Pedimos datos

Console.WriteLine("Ingrese un nro");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese otro nro");
n2 = int.Parse(Console.ReadLine()??"0");

if(n1 > n2){
    resultado = n1 - n2;
    Console.WriteLine("Resultado: " +resultado + "(Resta)");
} else if (n1 <  n2){
    resultado = n1 * n2;
    Console.WriteLine("Resultado: " + resultado + "(Multiplicación)");
} else if (n1 == n2){
    resultado = n1 + n2;
    Console.WriteLine("Resultado; " + resultado + "(Suma)");
}