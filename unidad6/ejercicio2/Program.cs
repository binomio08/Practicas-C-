// Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
//      -El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
//      -Informar cuántos grupos están formados por todos números ordenados de mayor a menor.


//Declaramos las variables
int n, contNros, contImpar, grupoMax = 0, min, contOrde = 0;
double porcImpar, porcImparMax = -1;
bool bando;

// Pedimos datos de 5 listas mediante un for
for (int i = 1; i <= 5; i++)
{
    contNros = 0;
    contImpar = 0;
    bando = true;
    Console.WriteLine("Ingrese un nro:");
    n = int.Parse(Console.ReadLine() ?? "0");
    min = n;
    while (n != 0)
    {
        contNros++;
        if (n % 2 != 0)
            contImpar++;
        // Segunda consigna
        if (n <= min)
            min = n;
        else
            bando = false;
        Console.WriteLine("Ingrese un nro:");
        n = int.Parse(Console.ReadLine() ?? "0");
    }//Fin del While
    porcImpar = (contImpar * 100) / contNros;
    if (porcImpar > porcImparMax)
    {
        porcImparMax = porcImpar;
        grupoMax = i;
    }
    //Segunda consigna
    if(bando)
        contOrde++;
}//Fin del FOR
Console.WriteLine("El grupo con mayor porcentaje de nros impares es: " + grupoMax + ", Con un porcentaje de: " + porcImparMax);
Console.WriteLine("La cantidad de grupos con nros ordeanados es:" + contOrde);