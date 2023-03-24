// See https://aka.ms/new-console-template for more information



int n, cont = 0;
Console.WriteLine("Ingrese un nro");
n= int.Parse(Console.ReadLine()??"0");

while(n != 0){
    cont++;
    Console.WriteLine("Ingrese un nro");
    n= int.Parse(Console.ReadLine()??"0");

}

Console.WriteLine("Ingresaste: " + cont + "nros.");
