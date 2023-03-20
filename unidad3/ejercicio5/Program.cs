// See https://aka.ms/new-console-template for more information


//Hacer un programa para ingresar cuatro números y luego
// mostrar por pantalla cuáles son mayores a 100.


int n1, n2, n3, n4, con = 0;

Console.WriteLine("Ingrese primer nro: ");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese segundo nro: ");
n2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese tercer nro: ");
n3 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese ultimo nro: ");
n4 = int.Parse(Console.ReadLine()??"0");

if(n1 > 100){
    Console.Write(n1+"... ");
    con++;
}
if(n2 > 100){
    Console.Write(n2+"... ");
    con++;
}
if(n3 > 100){
    Console.Write(n3+"... ");
    con++;
}
if(n4 > 100){
    Console.Write(n4+"... ");
    con++;
}
if(con != 0)
    Console.Write("Son mayor a 100.");