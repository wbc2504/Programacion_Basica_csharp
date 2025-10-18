/*Pide al usuario un número. Si es positivo, devuelve su raíz
cuadrada, de lo contrario, devuelve su cuadrado.   */
Console.WriteLine("Digita un numero: ");
double num = double.Parse(Console.ReadLine());
if (num > 0) Console.WriteLine($"La raiz cuadrada del numero es: {Math.Sqrt(num)}");
else Console.WriteLine($"El cuadrado del numero es: {num*num}");