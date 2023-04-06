// Hacer un programa para ingresar 10 números.
// El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

// Declaramos variables
int n, cont, nroPrimo = 0;

// Solicitmos los 10 nros a travez de un for y meidante otro for anidado verificamos que el numero ingresado sea primo
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese un nro al azar");
    n = int.Parse(Console.ReadLine()??"0");
    cont = 0;
    for (int x = 1; x <= n; x++)
    {
        if(n % x == 0)
            cont++;
    }
        if (cont == 2)
            nroPrimo++;
}
Console.WriteLine("La cantidad de nros primos ingresados son: " + nroPrimo);