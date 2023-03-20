// Hacer un programa para ingresar 4 números.
// Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .


// Declaramos variables


int n1, n2, n3, n4;


// Solicitamos datos


Console.WriteLine("Ingrese primer nro: ");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese Segundo nro: ");
n2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese tercer nro: ");
n3= int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese cuarto nro: ");
n4 = int.Parse(Console.ReadLine()??"0");


// Declaramos condiciones

if(n1 > n2 && n2 > n3 && n3 > n4)
    Console.WriteLine("Los numero estan ordenados de forma decreciente...");
    else
    Console.WriteLine("No estan ordenados");