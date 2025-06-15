// variables para el programa
int opcion;
string input;
bool bandera;
do
{
    // menu de opciones
    Console.WriteLine("\n\t\t-----Taller de lenguajes I------");
    Console.WriteLine("\n\t-----Menu de opciones------");
    Console.WriteLine("\t1-Valor Absoluto");
    Console.WriteLine("\t2-Cuadrado");
    Console.WriteLine("\t3-Raíz cuadrada");
    Console.WriteLine("\t4-Seno");
    Console.WriteLine("\t5-Coseno");
    Console.WriteLine("\t6-Parte entera de un número decimal");
    Console.WriteLine("\t7-Máximo entre dos números");
    Console.WriteLine("\t8-Mínimo entre dos números");
    Console.WriteLine("\t9-Sumar");
    Console.WriteLine("\t10-Restar");
    Console.WriteLine("\t11-Multiplicar");
    Console.WriteLine("\t12-Dividir");
    Console.Write("\n\tIngrese una opción (Enter para cancelar): ");

    // lectura de la entrada
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input)) break; /* control para a salir */

    bandera = int.TryParse(input, out opcion); /* conversion de la entrada a int */
    if (opcion < 1 || opcion > 12 || !bandera)    /* verificación de la opcion */
    {
        Console.WriteLine("Opcion invalida reingrese");
        continue;
    }
    // para el caso de las opciones de la 1 a la 6 necesitamos solo una opcion
    if (opcion >= 1 && opcion <= 6)
    {
        float numero;
        // bucle para el control de la entrada
        do
        {
            Console.Write("\nIngrese el numero a operar: ");
            bandera = float.TryParse(Console.ReadLine(), out numero);
            if (!bandera) Console.WriteLine("Valor invalido reingrese"); /* mensaje de error */
        } while (!bandera);
        switch (opcion) /* switch de opciones */
        {
            case 1:
                Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
                break;

            case 2:
                Console.WriteLine($"Cuadrado: {numero * numero}");
                break;

            case 3: /* uso de ternario para mostrar los mensajes */
                Console.WriteLine(numero >= 0 ? $"Raiz cuadrada {Math.Sqrt(numero)}" : "Error: no se puede sacar la raiz de un negativo");
                break;

            case 4:
                Console.WriteLine($"Seno: {Math.Sin(numero)}");
                break;

            case 5:
                Console.WriteLine($"Coseno: {Math.Cos(numero)}");
                break;

            default:
                Console.WriteLine($"Parte entera: {Math.Truncate(numero)}");
                break;
        }
    }
    else if (opcion > 6 && opcion < 13) /* para las demas opciones neesitamos des variables para los calculos */
    {
        float numero1, numero2;
        // bucles de control para las variables
        do
        {
            Console.Write("Ingrese el primer numero: ");
            bandera = float.TryParse(Console.ReadLine(), out numero1);
            if (!bandera) Console.WriteLine("Valor invalido reingrese"); /* mensaje de error */
        } while (!bandera);

        do  
        {
            Console.Write("Ingrese el segundo numero: ");
            bandera = float.TryParse(Console.ReadLine(), out numero2);
            if (!bandera) Console.WriteLine("Valor invalido reingrese"); /* mensaje de error */
        } while (!bandera);
        // switch de opciones
        switch (opcion)
        {
            case 7:
                Console.WriteLine($"Máximo: {Math.Max(numero1, numero2)}");
                break;

            case 8:
                Console.WriteLine($"Mínimo: {Math.Min(numero1, numero2)}");
                break;

            case 9:
                Console.WriteLine($"Resultado de la suma: {numero1 + numero2}");
                break;

            case 10:
                Console.WriteLine($"Resultado de la resta: {numero1 - numero2}");
                break;

            case 11:
                Console.WriteLine($"Resultado de la multiplicación: {numero1 * numero2}");
                break;

            default:    /* uso de ternario para mostrar mensajes */
                Console.WriteLine(numero2 != 0 ? $"Resultado de la división: {(float)numero1 / numero2}" : "Error no se puede dividir por cero");
                break;
        }
    }
    // bucle de control para continuar con los calculos
    do
    {
        Console.WriteLine("\nDesea realizar otra operacion?");
        Console.WriteLine("\t\t1- Si \t 2- No");
        bandera = int.TryParse(Console.ReadLine(), out opcion);
        if ((opcion != 1 && opcion != 2) || !bandera) Console.WriteLine("Entrada invalida reingrese");
    } while ((opcion != 1 && opcion != 2) || !bandera);
    
} while (opcion == 1);  /* control de la opcion del menu */