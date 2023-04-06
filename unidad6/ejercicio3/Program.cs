// Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
// El fin de la carga se notifica con un número negativo.
// Luego mostrar cuántos números tiene cada lista.

// Delcaramos variables
int n, contList = 0, contNro;

do
{
    contList++;
    contNro = 0;
    Console.WriteLine("Ingrese un nro");
    n = int.Parse(Console.ReadLine()??"0");
    while (n > 0){
        contNro++;
        Console.WriteLine("Ingrese un nro");
        n = int.Parse(Console.ReadLine()??"0");
}
Console.WriteLine("La cantidad del grupo " + contList + " es: " + contNro );
}while (n >= 0);
