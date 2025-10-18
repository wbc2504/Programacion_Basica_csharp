/* Calcula y muestra la suma de los números pares entre 1 y 50  */

Console.WriteLine("Suma de los numeros del 1 al 50");
int cuenta = 0;
for (int i = 2; i <= 50; i += 2)
{
     cuenta = cuenta + i;
}

Console.WriteLine($"La suma de los numeros del 1 al 50 es: {cuenta}");





