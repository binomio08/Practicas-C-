// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
//a. El mayor de los números pares.
//b. La cantidad de números impares.
//c. El menor de los números primos.
//Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaro variables globales 
        int nro, max = 0, contImpar = 0; bool banPar = false;

        //Solicito datos
        Console.WriteLine("Ingrese un nro...");
        nro = int.Parse(Console.ReadLine() ?? "0");

        // Evaluo el dato ingrasado a travez de while, mientras el dato no sea igual a 0 el ciclo continua pidiendo datos
        while (nro != 0)
        {
            // vuelvo a solicitar datos dentro del bucle while
            Console.WriteLine("Ingrese otro nro...");
            nro = int.Parse(Console.ReadLine() ?? "0");

            // Verifico si el numero ingresado es par o impar. En caso de que el nro ingresado sea par de verifica cual es el mayor.
            // por otra lado si el número es impar se cuenta.
            if(nro % 2 == 0)
            {
                if(banPar == false)
                {
                    max = nro;
                    banPar = true;
                }
                else if(nro > max)
                    max = nro;
            }
            else
            {
                contImpar ++;
            }
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