// See https://aka.ms/new-console-template for more information


// Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.



int n1, n2, n3, n4, menor;

Console.WriteLine("Ingrese primer nro: ");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese segundo nro: ");
n2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese tercer nro: ");
n3 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese ultimo nro: ");
n4 = int.Parse(Console.ReadLine()??"0");

if(n1 < n2)
    menor = n1;
else
    menor = n2;

if(n3 < menor)
    menor = n3;

if(n4 < menor)
    menor =n4;

Console.WriteLine("El valor menor es: " +menor);