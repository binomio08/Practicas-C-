// CADENA DE CARACTERES

//char[] cadena = new char[10];

//String = tipo de dato que nos permite cierta manipulación------tipo de dato cadena de caracteres
//CADENA DE CARACTERES = Es un vector de CHAR el cual vamos a utilizar para guardar una frase o "algo"
// BARRA CERO:
//cadena[5] = '\0';
//VECTOR DE CHAR =

// como cargar un nombre con cadena de caracteres

// char[] nombre = new char[11]; //Si queremos trabajar con 10 caracteres debemos colocar 11 para contemplar el '\0' del final 
// char letra; // lee y carga un caracter
// int indice = 0;  // guarda el caracter

// Console.WriteLine("Ingrese su nombre letra por letra(finaliza con un punto)");
// letra = char.Parse(Console.ReadLine()??"0");
// while(letra != '.' && indice < 10) //Colocamos un tope de 10 caracteres
// {
//     nombre[indice] = letra; //guarda al letra en el indice
//     letra = char.Parse(Console.ReadLine()??"0");
//     indice++;//va al proximo indice una vez cargado un caracter 
// }
// // if(indice == 10) // validacion del indice (que los caracteres no se pasen del indice), en caso de que declaremos la cadena de caracteres sea justo 10
// //     indice--;


// nombre[indice] = '\0';// Le damos fin a la cadena de caracteres
// // |l|e|a|n|d|r|o|\0| | |
// Console.Write("Hola ");
// indice = 0; //volvemos el indice a 0 o podemos crear uno nuevo
// while (nombre[indice] != '\0') // usamos otro while para mostrar el vector
// {
//     Console.Write(nombre[indice]);
//     indice++;
// }

string nombre;
Console.WriteLine("Ingrese se nombre...");
nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);

//Hace lo mismo que la primera funcion, pero mas sencillo(primera funcion es de bajo nivel y esta es de segundo nivel )