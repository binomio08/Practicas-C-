// Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
// Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

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