// variables para el programa
using Microsoft.VisualBasic;

int inverso = 0, numero = 0;
bool bandera;
string input;

do
{
    // mensaje inicial
    Console.WriteLine("Ingrese un numero un numero entero (Enter para salir):");
    input = Console.ReadLine(); /* guardado de la entrada como string */
    // verificacion si la entrada esta vacia para salir del programa
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Programa finalizado por el usuario.");/* mensjae de salida */
        return;
    }
    // Conversion a entero y verificacion con un booleano
    bandera = int.TryParse(input, out numero);
    
    if (!bandera || numero < 0)
    {
        Console.WriteLine("Entrada invalida reingrese"); /* mensaje de entrada invalida */
    }
    else
    {
        // logica para invertir un numero
        int copia = numero;
        while (copia > 0)
        {
            inverso = inverso * 10 + copia % 10;
            copia /= 10;
        }
        // mensaje de la inversion
        Console.WriteLine($"El numero ingresado es: {numero} \nEl numero invertido es: {inverso}");
    }
    inverso = 0; /* reinicio el valor para el siguiente bucle */
    
} while (bandera || numero <= 0);    /*la condicion es un numero mayor a 0 o que se haya ejecutado con exito */

