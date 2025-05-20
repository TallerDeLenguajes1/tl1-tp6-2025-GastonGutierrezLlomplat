Console.WriteLine("-- CALCULADORA V1 --");

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\nSeleccione una opción:");
    Console.WriteLine("1. Suma"); Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación"); Console.WriteLine("4. División");
    Console.Write("Ingrese una opción (1-4): ");

    string entrada = Console.ReadLine();
    bool opcionValida = int.TryParse(entrada, out int opcion);

    if (!opcionValida || opcion < 1 || opcion > 4)
    {
        Console.WriteLine("Opción inválida.");
        continue;
    }

    Console.Write("Ingrese el primer número: ");
    bool valido1 = int.TryParse(Console.ReadLine(), out int num1);
    Console.Write("Ingrese el segundo número: ");
    bool valido2 = int.TryParse(Console.ReadLine(), out int num2);

    if (!valido1 || !valido2)
    {
        Console.WriteLine("Uno o ambos valores ingresados no son válidos.");
        continue;
    }
    
    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
            break;
        case 2:
            Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
            break;
        case 3:
            Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
            break;
        case 4:
            if (num2 == 0) Console.WriteLine("No se puede dividir por cero.");
            else Console.WriteLine($"Resultado: {num1} / {num2} = {(double)num1 / num2}"); break;
    }

    Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    continuar = (respuesta == "s");
}