//Hacer un programa para ingresar tres números y
// emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.


// Declaramos variables

int n1, n2, n3, suma, multiplicacion;

//Solicitamos datos
Console.WriteLine("Ingrese primer nro");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese Segundo nro");
n2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese Tercer nro");
n3 = int.Parse(Console.ReadLine()??"0");

suma = n1 + n2;
multiplicacion = n2 * n3;

if(suma > multiplicacion)
    Console.WriteLine("La suma de los dos primero nros es mayor");



Console.WriteLine("Programa Finalizado.");