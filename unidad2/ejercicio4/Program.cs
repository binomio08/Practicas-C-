// See https://aka.ms/new-console-template for more information

//Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
//más una comisión del 5% sobre el total facturado por cada empleado. 
//Hacer un programa para ingresar el total facturado por un empleado 
//luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

// Sueldo fijo: 15000
// comision: 5% del total facturado

// Declaramos variables
float totalFacturado, comision, totalPagar;

    //variables constante
const float sueldoFijo = 15000;
const float porcentajeComision = 0.05F;

//Pedimos el total facturado
Console.WriteLine("Ingrese el Total Facturado");
totalFacturado = float.Parse(Console.ReadLine()??"0");

//Calculamos el procentaje del total facturado

comision = totalFacturado * porcentajeComision;

//total a pagar 

totalPagar= comision + sueldoFijo;

// mostramos por pantalla el total a paagar al empleado

Console.WriteLine("Total a pagar a su empleado es: $" + totalPagar);
