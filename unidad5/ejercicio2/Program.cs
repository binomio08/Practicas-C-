// Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
//Solo se debe emitir UN valor por pantalla.


// Declaramos variables

int n, max = 0;


// Solicitamos datos con FOR

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un nro:");
    n = int.Parse(Console.ReadLine()??"0");
    
    if(i == 0)
        max = n;
        else{
            if(n > max)
                max = n;
        }
}
Console.WriteLine("El nro. mayor ingresado es: " + max);