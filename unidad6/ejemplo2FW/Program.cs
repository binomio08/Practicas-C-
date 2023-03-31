// ejemplo 2 de ciclos conbinados 

// Queremos cargar datos de un equipo de futbol
// pero no sabemos cuantos jugadores tiene cada equipo
int n, acu = 0, con, prom;


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingresa la edad");
n = int.Parse(Console.ReadLine() ?? "0");
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
}

