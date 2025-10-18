/* Solicita dos números y muestra el residuo de la división del
primero entre el segundo.  */

Console.WriteLine("Digita el primer numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digita el segundo numero, debe ser diferente de cero: ");
int num2 = int.Parse(Console.ReadLine());

while (num2 == 0){
Console.WriteLine("El segundo numero no puede ser cero, digita otro nuevamente: ");
num2 = int.Parse(Console.ReadLine());
}

Console.WriteLine($"El residuo entre el numero {num1} y el numero {num2} es: {num1 % num2}");