// Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
// calculadora.. Solicite al usuario un número y muestre por pantalla:
// ● El valor absoluto de un número, El cuadrado, La raíz cuadrada, El seno, El Coseno, La parte entera de un
// tipo float.
// Luego de esto, solicite dos números al usuario y determine:
// ● El Máximo entre los dos números
// ● El Mínimo entre los dos números
// Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no ingrese un número válido

using System.Diagnostics;

Console.WriteLine("-- CALCULADORA V1 --");

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
    Console.Write("Ingrese una opción (1-6): ");

    string entrada = Console.ReadLine();
    bool opcionValida = int.TryParse(entrada, out int opcion);

    if (!opcionValida || opcion < 1 || opcion > 6)
    {
        Console.WriteLine("Opción inválida.");
        continue;
    }

    Console.Write("Ingrese el número: ");
    bool valido1 = float.TryParse(Console.ReadLine(), out float num1);

    if (!valido1)
    {
        Console.WriteLine("Valor ingresado incorrecto.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            if (num1 < 0)
            {
                Console.WriteLine($"Valor absoluto: {num1 - 2 * num1}");
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
            Console.WriteLine($"Resultado: {Math.Sqrt(num1)}");
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
    }

    Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    continuar = (respuesta == "s");
}