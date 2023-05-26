// Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
// que reciba un número por valor y una variable por referencia.
// Que analice el número y escriba variable recibida por referencia con:

//a. 1 si el número es positivo.
//b. -1 si el número es negativo.
//c. 0 si el número es cero.

int nro, status = 9;

Console.WriteLine("Ingrese un nro...");
nro = int.Parse(Console.ReadLine()??"0");

positicoNegativoCero(nro, ref status);

Console.WriteLine("El estado del valor " + nro +" es "+ status);

static void positicoNegativoCero(int n, ref int estado){
    if(n == 0) estado = 0;
    else if (n > 0) estado = 1;
    else estado = -1;
}