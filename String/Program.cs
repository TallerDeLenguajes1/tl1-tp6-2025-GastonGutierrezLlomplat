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
Console.Write("Ingrese caracteres que piense que están en la cadena: ");
string palabraBuscada = Console.ReadLine();
bool contiene = mensaje.Contains(palabraBuscada);

// Separar una cadena
string cadenaSeparada = "uno-dos-tres-cuatro";
string[] partes = cadenaSeparada.Split('-');

Console.WriteLine("\nElementos separados:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

// Convertir a mayúsculas y luego a minúsculas
string mayus = Console.ReadLine().ToUpper();
string minus = Console.ReadLine().ToLower();

Console.WriteLine($"\nEn mayúsculas: {mayus}");
Console.WriteLine($"En minúsculas: {minus}");

// Operaciones y mensaje con ToString()
int num1 = 5;
int num2 = 7;
int resultado = num1 + num2;

string mensajeCalc = $"La suma de {num1} y de {num2} es igual a: {resultado.ToString()}";
Console.WriteLine(mensajeCalc);