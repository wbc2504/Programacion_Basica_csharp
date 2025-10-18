﻿/*Solicita al usuario dos números. Si el primero es mayor, devuelva
su doble, de lo contrario devuelva el triple del segundo.  */
Console.WriteLine("Digita el primer numero: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digita el segundo numero: ");
double num2 = double.Parse(Console.ReadLine());
if (num1 > num2) Console.WriteLine($"El doble del primer numero es: {num1 * 2}");
else Console.WriteLine($"El triple del segundo numero es: {num2*3}");