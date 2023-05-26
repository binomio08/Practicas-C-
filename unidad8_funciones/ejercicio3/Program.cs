// Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
// Hacer un programa para ingresar números. 
// El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

int n, acuPrimos = 0, contPrimos = 0;
float promedio;
Console.WriteLine("Ingrese un nro (0 para finalizar)");
n = int.Parse(Console.ReadLine()??"0");
while (n != 0)
{
    if(primo(n)){
        contPrimos++;
        acuPrimos += n;
    }

    Console.WriteLine("Ingrese otro (0 para finalizar)");
    n = int.Parse(Console.ReadLine()??"0");

}

promedio = acuPrimos / contPrimos;
    Console.WriteLine("El promedio de nros primos es: " + promedio);


static bool primo(int a){
    int cont = 0;
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0){
            cont++ ;
        }
    }
    if (cont == 2){
        return true;
    }
    else return false ;
}
