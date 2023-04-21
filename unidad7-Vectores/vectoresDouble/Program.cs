// Tipos de datos
// int(long, short)
// float - double - decimal

double[] muestraMatutina = new double[31];
double[] muestraVespertina = new double[31];
double[] muestraNocturna = new double[31];

// Registro Matutino
int dia;
double temperatura;
Console.WriteLine("Cargue el registro Matutino");
for (int x = 0; x < 31; x++)
{
    Console.WriteLine("Ingrese día: ");
    dia = int.Parse(Console.ReadLine()??"0");
    Console.WriteLine("Ingrese Temperatura Registrada");
    temperatura = double.Parse(Console.ReadLine()??"0");

    muestraMatutina[dia-1] = temperatura;
}
for (int x = 0; x < 31; x++)
{
    
}
for (int x = 0; x < 31; x++)
{
    
}