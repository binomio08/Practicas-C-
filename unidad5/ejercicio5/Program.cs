// Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

//Declaramos variables
int n , max = 0 , min = 0, contImpar = 0;
bool banPar = false;
// Pedimos Datos mediante for

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Ingrese un nro: ");
    n = int.Parse(Console.ReadLine()??"0");

    // Preguntamos si es par mediante condicional IF
    if(n % 2 == 0){
        if(banPar == false){
            max = n;
            banPar = true;
        }else if(n > max)
            max = n;
    }else{
        contImpar++;
        if(contImpar == 1)
            min = n;
        else if(n < min)
            min = n;
    }       
}
Console.WriteLine("El mayo nro par es: " + max);
Console.WriteLine("El menor nro Impar es: " + min);