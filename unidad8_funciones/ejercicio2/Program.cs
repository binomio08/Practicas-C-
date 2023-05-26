// Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
// Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

static int par(int a){
    if (a % 2 == 0)
        return 1;
    else return 0; 
}

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("ingrese un nro...");
    int num = int.Parse(Console.ReadLine()??"0");
    int solu = par(num);
    Console.WriteLine(solu);
    }