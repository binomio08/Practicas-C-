// Ejemplo WHile con For
// sabemos que un equipo tiene 20 jugadores, pero, no sabemos cuantos equipos debemos cargar
// por lo tanto usamos While con For



int n, acu = 0, prom;


Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar");
n = int.Parse(Console.ReadLine()??"0");
while(n != 0 ){
    acu = 0;
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Ingrese edad del jugador");
        n = int.Parse(Console.ReadLine()??"0");
        acu += n;
    }

    prom = acu / 4;
    Console.WriteLine("El Promedio de edades es: " + prom);

    Console.WriteLine("Ingrese 1 para continuar cargando equipos o cero para Finalizar");
    n = int.Parse(Console.ReadLine()??"0");
}

