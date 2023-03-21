// Hacemos un  ciclo for. 
// Diseñamos un programa que pregunte 10 nros y te de un promedio



// Usamos ciclo for

// for(int i = 0; i < 5; i++){
//     Console.WriteLine("Hola Mundo " + (i + 1));
// }


//Otro ejemplo con for

int n = 0, promedio, suma = 0;


for (int i = 0; i < 5; i++)
{    
Console.WriteLine("Ingrese un nro:" );
n = int.Parse(Console.ReadLine()??"0");
suma =+ n;
}
promedio = suma / 5;
Console.WriteLine("EL promedio es: " + n);