Console.Write("Ingrese una cadena de texto: ");
string cadena1 = Console.ReadLine();

// Longitud
int cadena1Longitud = cadena1.Length;
Console.WriteLine($"La cadena de texto '{cadena1}' tiene {cadena1Longitud} caracteres de longitud");

// Concatenación
Console.Write("Ingrese otra cadena de texto: ");
string cadena2 = Console.ReadLine();
Console.WriteLine($"{cadena1} {cadena2}");

// Subcadena
Console.WriteLine(cadena2.Substring(0, 3));

// Ciclo for each
foreach (char c in cadena2)
{
    Console.WriteLine(c);
}

// Ocurrencia de una palabra
Console.Write("Ingrese caracteres que piense que están en la cadena: ")
string palabraBuscada = C
bool contiene = mensaje.Contains(palabraBuscada);