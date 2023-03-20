// See https://aka.ms/new-console-template for more information


int contador = 0, e1 = 20, e2 = 30 , e3 = 10;
int acumulador = 0, promedio;


if(e1 > 18){
    contador = contador +1;
    acumulador = acumulador + e1;
}
if(e2 > 18){
    contador ++;
    acumulador += e2;
}
if(e3 > 18){
    contador ++;
    acumulador += e3;
}
promedio = acumulador / contador;
Console.WriteLine("El promedio es: " + promedio);