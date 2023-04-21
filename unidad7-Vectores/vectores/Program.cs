// Vectores. Array. Arreglo
// int a = 0;
int n;
int[] numeros = new int[10];//forma de escribir la declaración de la variable (vector).

//  0 1 2 3 4 5 6 7 8 9   indices de cada uno de los espacios de memoria
// | | | | | | | | | | |

// numeros[6] = 1;
// numeros[0] = 7;
// numeros[9] = 32450;

// a = numeros[0] + numeros[6] + numeros[9];
// Console.WriteLine(numeros[9]);
// Console.WriteLine(a);

for (int x = 0; x < 10; x++)
{
    Console.WriteLine("Ingrese la nota...");
    n = int.Parse(Console.ReadLine()??"0");
    numeros[x] = n;
}

int acu = 0;

for (int x = 0; x < 10; x++)
{
    acu += numeros[x];
}

int prom = acu / 10;

Console.WriteLine("El promedio es: " +prom);