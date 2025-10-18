/*  Descripción: Pide una palabra al usuario y muestra la longitud de esa palabra.   */

Console.WriteLine("Digita una palabra: ");
String palabra = Console.ReadLine();

int cantidadLetras = 0;
foreach (char p in palabra)
{
  cantidadLetras ++;
}

Console.WriteLine($"La cantidad de letras de la palabra {palabra} es: {cantidadLetras}");






