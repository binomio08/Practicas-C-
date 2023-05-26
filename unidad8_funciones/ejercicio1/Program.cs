// Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
// Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar.
// Usar la función.

int n1 , n2;

static int producto(int a, int b){
    int resp =  a * b;
    return resp;
}

Console.WriteLine("Ingrese precio del articulo...");
n1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese la cantidad del articulo a llevar...");
n2 = int.Parse(Console.ReadLine()??"0");

int precioTotal = producto(n1, n2);

Console.WriteLine("El Total a pagar es: " + precioTotal);
