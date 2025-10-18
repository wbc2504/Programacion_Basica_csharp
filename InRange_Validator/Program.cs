/**Descripción: Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos).*/

Console.WriteLine("Digita un numero: ");
double numero = double.Parse(Console.ReadLine());

if (numero < 20 && numero > 10)
{
    Console.WriteLine($"Numero {numero} dentro del rango");
}
else
{
    Console.WriteLine($"Numero {numero} fuera del rango");
}

