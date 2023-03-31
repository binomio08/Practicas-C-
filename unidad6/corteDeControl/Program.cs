// Corte de Control: (manejar lotes de datos agrupados)
// Trabajamos con grupos- agrupación

// ejemplo 
// legajo, edad, suedo, código de equipo

int legajo, edad, codigoEquipo;
float sueldo;
int equipoActual;

/// Código de equipos
// 1 River 
// 2 Boca
// 3 Racing 

Console.WriteLine("Ingrese el legajo");
legajo = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese la edad");
edad = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese el Sueldo");
sueldo = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese el código de equipo");
codigoEquipo = int.Parse(Console.ReadLine() ?? "0");

while (sueldo > 0 )
{
    equipoActual = codigoEquipo;
    while (codigoEquipo == equipoActual)
    {
        // Acá procesamos datos
        Console.WriteLine("Ingrese el legajo");
        legajo = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese la edad");
        edad = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el Sueldo");
        sueldo = float.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el código de equipo");
        codigoEquipo = int.Parse(Console.ReadLine() ?? "0");
        // Acá se puede mostrar resultados
    }

    //Mostrar lo que necesite mostrar
}

//Acá también se puede mostrar resultados
