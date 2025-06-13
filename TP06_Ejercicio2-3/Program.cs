// variables para el programa
int numero1, numero2, opcion;
string input;
bool bandera;
do
{
    // menu de opciones
    Console.WriteLine("\t\t\n-----Taller de lenguajes I------");
    Console.WriteLine("\t\n-----Menu de opciones------");
    Console.WriteLine("\t1__Sumar");
    Console.WriteLine("\t2__Restar");
    Console.WriteLine("\t3__Multiplicar");
    Console.WriteLine("\t4__Dividir");
    Console.WriteLine("\t5__Salir");

    // lectura de la entrada
    input = Console.ReadLine();
    bandera = int.TryParse(input, out opcion); /* conversion de la entrada a int */
    if (opcion < 1 || opcion > 5 || string.IsNullOrEmpty(input) || !bandera)    /* verificación de la opcion */
    {
        Console.WriteLine("Opcion invalida reingrese");
    }
    else if (opcion != 5)   /* si no seleccionamos salir entramos a la lógica del programa */
    {
        // bucles para ingresar numeros validos
        do
        {
            Console.WriteLine("Ingrese el primer numero: ");
            bandera = int.TryParse(Console.ReadLine(), out numero1);
            if (!bandera) Console.WriteLine("Valor invalido reingrese"); /* mensaje de error */
        } while (!bandera);

        do
        {
            Console.WriteLine("Ingrese el segundo numero: ");
            bandera = int.TryParse(Console.ReadLine(), out numero2);
            if (!bandera) Console.WriteLine("Valor invalido reingrese"); /* mensaje de error */
        } while (!bandera);

        /* switch de opciones */
        switch (opcion)
        {
            /* resultados */
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
                if (numero2 != 0) /* constrol de que no se divida por 0 */
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
        Console.WriteLine("Saliendo del programa"); /* mensaje de salida */
    }
} while (opcion != 5);  /* control de la opcion del menu */