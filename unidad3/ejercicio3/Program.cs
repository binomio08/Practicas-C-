// See https://aka.ms/new-console-template for more information

// Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
// Si el importe es menor a ARS 1000, no hay descuento.
// Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
// Si el importe es ARS 5000 o más, aplica un descuento del 18%.
// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.


//Declaramos variables
float importe, descuento10, descuento18;

//Solicitamos dato
Console.WriteLine("Ingrese importe: (para saber su descuento)");
importe = float.Parse(Console.ReadLine()??"0");

//Calcular descuentos segun corresponda

if(importe >= 1000 && importe < 5000){
    descuento10 = importe * 0.90F;
    Console.WriteLine("Total con descuento: $" + descuento10);

} else if(importe >= 5000){
    descuento18 = importe * 0.82F;
    Console.WriteLine("Total con descuento: $" + descuento18);
}else{
    Console.WriteLine("No corresponde descuento: $" + importe);
}

