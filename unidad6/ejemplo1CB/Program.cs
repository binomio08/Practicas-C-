// Cxclos combxnados
// Combxnar cxclos


// FOR con FOR
// ejemplo: queremos cargar las edades de 10 equipos de futbol, de los cuales, cada equipo tiene 20 jugadores

int prom, acu , n;


for (int y = 0; y < 10; y++)
{
    acu = 0;
    for (int x = 0; x < 20; x++)
    {
        Console.WriteLine("Ingrese la edad de cada jugador: ");
        n = int.Parse(Console.ReadLine() ?? "0");
        acu += n;
    }

    prom = acu / 20;
    Console.WriteLine("La edad Promedio es: " + prom);

}

