int n, cont = 0;


do{
    Console.WriteLine("Ingrese un nro:");
    n = int.Parse(Console.ReadLine()??"0");
    cont++;
}while( n != 0);


Console.WriteLine("Usted ingresó:  " + cont + "Nros.");
