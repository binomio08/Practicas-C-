int n1 = 0 , n2 = 0, resultado;

pedirDatos( ref n1, ref n2);

resultado = sumar(n1 , n2);

Console.WriteLine("El resultado es: " + resultado);

static int sumar(int a, int b){
    int r;
    r = a + b;
    return r;
}

static void pedirDatos(ref int j, ref int h){
    Console.WriteLine("Ingrese un nro...");
    j = int.Parse(Console.ReadLine()??"0");
    Console.WriteLine("Ingrese un nro...");
    h = int.Parse(Console.ReadLine()??"0");
}


