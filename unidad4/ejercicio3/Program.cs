internal class Program
{
    private static void Main(string[] args)
    {

        //decalramos variables
        int ram, procesador, disco;
        float precio;

        //Solicitamos datos
        Console.WriteLine("Ingrese la opción de procesador: ");
        procesador = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese la opción de Mermoria RAM: ");
        ram = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Amplia disco?");
        disco = int.Parse(Console.ReadLine() ?? "0");

        // Declaramos condiciones
        if (procesador == 1)
        {
            switch (ram)
            {
                case 1:
                    precio = 800;
                    break;
                case 2:
                    precio = 900;
                    break;
                default:
                    precio = 1000;
                    break;
            }
            if (disco == 1)
                precio = precio + 300;
            Console.WriteLine("El precio final de la computadora es: " + precio + "USD");
        }
        else if (procesador == 2)
        {
            switch (ram)
            {
                case 1:
                    precio = 900;
                    break;
                case 2:
                    precio = 1000;
                    break;
                default:
                    precio = 1400;
                    break;
            }
            if (disco == 1)
                precio = precio + 300;
            Console.WriteLine("El precio final de la computadora es: " + precio + "USD");
        }
        else if (procesador == 3)
        {
            switch (ram)
            {
                case 1:
                    precio = 1200;
                    break;
                case 2:
                    precio = 1400;
                    break;
                default:
                    precio = 2000;
                    break;
            }
            if (disco == 1)
                precio = precio + 300;
            Console.WriteLine("El precio final de la computadora es: " + precio + "USD");
        }
    }
}