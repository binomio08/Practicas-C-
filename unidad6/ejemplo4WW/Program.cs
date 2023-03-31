// No sabemos cuantos equipos vamos a cargar ni cuantos jugadores tpiene cada equipo
// Usaremos WHILE CON WHILE

int n, acu = 0, con, prom;

Console.WriteLine("Ingresa la edad");
n = int.Parse(Console.ReadLine() ?? "0");
while( n > 0){

acu = 0;
con = 0;
while (n != 0)
{
    acu += n;
    con++;
    Console.WriteLine("Ingresa la edad");
    n = int.Parse(Console.ReadLine() ?? "0");
}

prom = acu / con;
Console.WriteLine("El promedio es: " + prom);
Console.WriteLine("Ingresa la edad para continuar o ingrese un nro negativo para cortar");
    n = int.Parse(Console.ReadLine() ?? "0");
}

