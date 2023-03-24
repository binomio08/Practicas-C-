// Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

// Declaramos variables

int edad, promedio, suma = 0 , cont = 0;

// Solicitamos datos

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Ingrese Edad");
    edad = int.Parse(Console.ReadLine()??"0");

    if(edad > 18){
        cont++;
        suma += edad;
    }
}
promedio = suma / cont; 
Console.WriteLine("El promedio de mayores a 18 es: " + promedio);