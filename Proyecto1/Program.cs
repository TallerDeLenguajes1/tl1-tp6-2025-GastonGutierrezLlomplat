
Console.WriteLine("-- CALCULADORA V2 --");

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\nSeleccione una opción:");
    Console.WriteLine("1. Valor absoluto");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Raiz cuadrada");
    Console.WriteLine("4. Coseno");
    Console.WriteLine("5. Seno");
    Console.WriteLine("6. Parte entera de un decimal");
    Console.WriteLine("7. Suma");
    Console.WriteLine("8. Resta");
    Console.WriteLine("9. Multiplicación");
    Console.WriteLine("10. División");
    Console.Write("Ingrese una opción (1-10): ");

    string entrada = Console.ReadLine();
    bool opcionValida = int.TryParse(entrada, out int opcion);
    float num1 = 0;
    float num2 = 0;
    bool valido1 = false;
    bool valido2 = false;

    if (!opcionValida || opcion < 1 || opcion > 10)
    {
        Console.WriteLine("Opción inválida.");
        continue;
    }

    if (opcion >= 1 && opcion <= 6)
    {
        Console.Write("Ingrese el primer número: ");
        valido1 = float.TryParse(Console.ReadLine(), out num1);
        valido2 = true;
    }
    else
    {
        Console.Write("Ingrese el primer número: ");
        valido1 = float.TryParse(Console.ReadLine(), out num1);
        Console.Write("Ingrese el segundo número: ");
        valido2 = float.TryParse(Console.ReadLine(), out num2);
    }

    

    if (!valido1 || !valido2)
    {
        Console.WriteLine("Uno o ambos valores ingresados no son válidos.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            if (num1 < 0)
            {
                Console.WriteLine($"Valor absoluto: {Math.Abs(num1)}");
            }
            else
            {
                Console.WriteLine($"Valor absoluto: {num1}");
            }
            break;
        case 2:
            Console.WriteLine($"Resultado: {num1 * num1}");
            break;
        case 3:
            if (num1 < 0)
            {
                Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            else
            {
                Console.WriteLine($"Resultado: {Math.Sqrt(num1)}");
            }
            break;
        case 4:
            Console.WriteLine($"Resultado: {Math.Cos(num1)}");
            break;
        case 5:
            Console.WriteLine($"Resultado: {Math.Sin(num1)}");
            break;
        case 6:
            Console.WriteLine($"Resultado: {Math.Truncate(num1)}");
            break;
        case 7:
            Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
            break;
        case 8:
            Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
            break;
        case 9:
            Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
            break;
        case 10:
            if (num2 == 0) Console.WriteLine("No se puede dividir por cero.");
            else Console.WriteLine($"Resultado: {num1} / {num2} = {(double)num1 / num2}"); break;
    }

    Console.WriteLine("\nIngrese dos números para comparar:");

    bool esValido1 = float.TryParse(Console.ReadLine(), out float numero1);
    bool esValido2 = float.TryParse(Console.ReadLine(), out float numero2);

    if (!esValido1 || !esValido2)
    {
        Console.WriteLine("Al menos uno de los valores ingresados no es un número válido.");
    }
    else
    {
        float max = Math.Max(numero1, numero2);
        float min = Math.Min(numero1, numero2);

        if (numero1 == numero2)
        {
            Console.WriteLine("Ambos números son iguales.");
        }
        else
        {
            Console.WriteLine($"El máximo es {max} y el mínimo es {min}.");
        }
    }

    Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    continuar = (respuesta == "s");
}