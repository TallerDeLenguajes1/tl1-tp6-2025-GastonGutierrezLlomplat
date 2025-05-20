// Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
// texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
// número sólo si éste es mayor a 0.

Console.WriteLine("-- INVERSION DE UN NUMERO --");
Console.WriteLine("Ingrese un numero: ");

string entrada = Console.ReadLine();
int numero = 0;
bool resultado = int.TryParse(entrada, out numero);

if (resultado && numero > 0)
{
    numero = numero - 2 * numero;
    Console.WriteLine("El numero inverso es: ");
    Console.Write(numero);
} else {
    Console.WriteLine("El numero no es mayor a cero.");
}