/* Pide una palabra al usuario y devuelve el número de vocales en
esa palabra. */

Console.WriteLine("Digita una palabra: ");
String palabra = (Console.ReadLine());

int contador=0;
for (int i = 0; i < palabra.Length; i++)
{
    if (palabra[i]=='a' || palabra[i]=='e' || palabra[i]== 'i' || palabra[i]=='o' || palabra[i]=='u')
    {
          contador ++;
    }
}

Console.WriteLine($"La cantidad de vocales de la palabra {palabra} es: {contador}");