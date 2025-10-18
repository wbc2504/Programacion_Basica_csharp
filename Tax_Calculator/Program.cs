/* Solicita al usuario su salario anual y, si este excede los 12000,
muestra el impuesto a pagar que es el 15% del excedente.  */

Console.WriteLine("Digita tu salario anual");
double salario = double.Parse(Console.ReadLine());
const double tope = 12000;
if (salario > 12000) Console.WriteLine($"El impuesto a pagar es: {(salario - tope)*0.15}");
else Console.WriteLine("No aplica para pagar impuestos");