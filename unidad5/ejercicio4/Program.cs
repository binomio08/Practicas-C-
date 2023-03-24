// Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
//Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

// Declaramos Variables
int n, cont = 0;

// Solicitmos Datos

Console.WriteLine("Ingrese un nro:");
n = int.Parse(Console.ReadLine()??"0");

// Verificamos si es numero primo mediante un For

for(int i = 1; i <= n; i++){
    if(n % i == 0)
        cont++;
}
if(cont == 2)
    Console.WriteLine("El nro es Primo");
else
    Console.WriteLine("El nro NO el Primo");