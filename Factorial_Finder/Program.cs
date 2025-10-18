/*  Pide un número al usuario y devuelve el factorial de ese número. 
 */
Console.WriteLine("Digita un numero entero: ");
int numero = int.Parse(Console.ReadLine() );
int factorial = numero;
for (int i = (numero -1); i > 0 ; i--)
{
   factorial = factorial*i;
}

Console.WriteLine($"El factorial del numero {numero} es: {factorial}");