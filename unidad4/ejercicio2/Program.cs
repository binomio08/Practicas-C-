// See https://aka.ms/new-console-template for more information


//Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
    //Si vende menos de 100 litros, no hay descuento.
    //Si vende entre 101 y 300 litros, el descuento es del 10%.
    //Si vende entre 301 y 500 litros, el descuento es del 15%.
    //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
//Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.


//Declaramos variables

float importeTotal, litros; //descuento;

//Pedimos Datos
//Solicitamos el importe total
Console.WriteLine("Ingrese el importe total");
importeTotal = float.Parse(Console.ReadLine()??"0");
//Solicitamos la cantidad de litros vendidos
Console.WriteLine("Ingrese la cantidad de litros vendidos");
litros = float.Parse(Console.ReadLine()??"0");


// if(litros >= 101 && litros <= 300){
//     descuento = importeTotal * 0.90F;
//     Console.WriteLine("El total a pagar con descuento es: $" + descuento);
// }else if(litros >= 301 && litros <= 500){
//     descuento = importeTotal * 0.85F;
//     Console.WriteLine("El total a pagar con descuento es: $" + descuento);
// }else if(litros > 500){
//     descuento = importeTotal * 0.75F;
//     Console.WriteLine("El total a pagar con descuento es: $" + descuento);
// }else
//     Console.WriteLine("Lamentablemente no entra en el descuento, total a pagar: $" + importeTotal);

// Forma altenrnativa sin tanto código
if(litros > 500)
    importeTotal *= 0.75F;
else if(litros > 300)
    importeTotal *= 0.85F;
else if(litros > 100)
    importeTotal *= 0.90F;

Console.WriteLine("El Importe final a pagar es: $"+ importeTotal);