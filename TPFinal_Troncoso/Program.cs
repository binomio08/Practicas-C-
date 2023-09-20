// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
//a. El mayor de los números pares.
//b. La cantidad de números impares.
//c. El menor de los números primos.
//Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaro variables globales 
        int nro;

        //Solicito datos
        Console.WriteLine("Ingrese un nro...");
        nro = int.Parse(Console.ReadLine() ?? "0");

        // Evaluo el dato ingrasado a travez de while, mientras el dato no sea igual a 0 el ciclo continua pidiendo datos
        while (nro != 0)
        {
            // vuelvo a solicitar datos dentro del bucle while
            Console.WriteLine("Ingrese otro nro...");
            nro = int.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine();

    }

    // Declaro una función llamada primos que evalua si el número ingrasado es primo(devuelve un true) o no(devuelve un false) 
    static bool primos(int a)
    {
        int cont = 0;
        for (int i = 1; i <= a; i++)
        {
        if (a % i == 0) cont++;
        }
        if (cont == 2) return true;
        else return false;
    }
}