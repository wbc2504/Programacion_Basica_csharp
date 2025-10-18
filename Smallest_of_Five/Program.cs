/* Pide al usuario cinco números y muestra el más pequeño. */

Console.WriteLine("Digita el primer numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digita el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digita el tercer numero: ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Digita el cuarto numero: ");
int num4 = int.Parse(Console.ReadLine());
Console.WriteLine("Digita el quinto numero: ");
int num5 = int.Parse(Console.ReadLine());

int menor = 0;
if (num1>num2) 
{
  menor = num2;
}
else if (num2>num3)
{
  menor = num3;
}
else if (num3>num4)
{
  menor = num4;
}
else if (num4>num5)
{
  menor = num5;
}
else
{
menor = num1;
}

Console.WriteLine($"El numero menor de los 5 digitados es: {menor}");