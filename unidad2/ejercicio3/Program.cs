// See https://aka.ms/new-console-template for more information

// declaramos las variable

float r, v, tiempo;

// pedimos datos

Console.WriteLine("Ingrese la distnacia del Destino (KM):");
r = float.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ingrese la velocidad promedio(K/h):");
v = float.Parse(Console.ReadLine()??"0");

//Calculamos velocidad

tiempo = r/v;

//mostramos el resultado
Console.WriteLine("El tiempo aproximado de llegada es: " + tiempo.ToString("0.00") + "Hs");