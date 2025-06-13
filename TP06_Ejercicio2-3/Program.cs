int numero1, numero2, opcion;
string input;
bool bandera;
do
{
    Console.WriteLine("\n-----Taller de lenguajes I------");
    Console.WriteLine("\n-----Menu de opciones------");
    Console.WriteLine("1-\tSumar");
    Console.WriteLine("2-\tRestar");
    Console.WriteLine("3-\tMultiplicar");
    Console.WriteLine("4-\tDividir");
    Console.WriteLine("5-\tSalir");

    input = Console.ReadLine();
    bandera = int.TryParse(input, out opcion);
    if (opcion < 1 || opcion > 5 || string.IsNullOrEmpty(input) || !bandera)
    {
        Console.WriteLine("Opcion invalida reingrese");
    }
    else if (opcion != 5)
    {
        do
        {
            Console.WriteLine("Ingrese el primer numero: ");
            bandera = int.TryParse(Console.ReadLine(), out numero1);
            if (!bandera)Console.WriteLine("Numero invalido reingrese");              
        } while (!bandera);
        do
        {
            Console.WriteLine("Ingrese el segundo numero: ");
            bandera = int.TryParse(Console.ReadLine(), out numero2);
            if (!bandera)Console.WriteLine("Numero invalido reingrese");              
        } while (!bandera);

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado de la suma: {numero1 + numero2}");
                break;
            case 2:
                Console.WriteLine($"Resultado de la resta: {numero1 - numero2}");
                break;
            case 3:
                Console.WriteLine($"Resultado de la multiplicación: {numero1 * numero2}");
                break;
            case 4:
                if (numero2 != 0)
                {
                    Console.WriteLine($"Resultado de la division: {(float)numero1 / numero2}");
                }
                else
                {
                    Console.WriteLine("Error no se puede dividir por cero");
                }
                break;
            default:
                break;
        }
    }else
    {
        Console.WriteLine("Saliendo del programa");
    }
} while (!bandera || opcion != 5);