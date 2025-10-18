/*Pide al usuario el radio de un círculo y calcula su perímetro. */
Console.WriteLine("Digita el radio del circulo: ");
double radio = double.Parse(Console.ReadLine());
Console.WriteLine($"El perimetro del circulo es: {2*Math.PI*radio}");