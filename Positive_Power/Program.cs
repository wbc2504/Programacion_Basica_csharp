/*Descripción: Solicita al usuario un número y eleva este número al cuadrado
solo si es positivo. */
Console.WriteLine("Digita un numero: ");
double num = double.Parse(Console.ReadLine());
if (num > 0) Console.WriteLine($"El cuadrado del numero es: {num * num}");
else if (num < 0) Console.WriteLine("El numero es negativo");
else Console.WriteLine("El numero es cero");