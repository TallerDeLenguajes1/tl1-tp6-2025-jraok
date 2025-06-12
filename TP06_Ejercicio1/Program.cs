int inverso = 0, numero = 0;
bool bandera;
string input;

do
{
    Console.WriteLine("Ingrese un numero un numero entero (Enter para salir):");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Programa finalizado por el usuario.");
        return;
    }
    bandera = int.TryParse(input, out numero);
    if (!bandera || numero < 0)
    {
        Console.WriteLine("Entrada invalida reingrese");
    }
    else
    {
        int copia = numero;
        while (copia > 0)
        {
            inverso = inverso * 10 + copia % 10;
            copia /= 10;
        }
        Console.WriteLine($"El numero ingresado es: {numero} \nEl numero invertido es: {inverso}");
    }
    inverso = 0;
} while (bandera || numero < 0);

