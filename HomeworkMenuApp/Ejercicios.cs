using System;
namespace HomeworkMenuApp;
    class Ejercicio1()
    {
       public void run() {
            /*Descripción: Solicita al usuario un número y eleva este número al cuadrado
            solo si es positivo. */
            Console.WriteLine("Digita un numero: ");
            double num = double.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine($"El cuadrado del numero es: {num * num}");
            else if (num < 0) Console.WriteLine("El numero es negativo");
            else Console.WriteLine("El numero es cero");
        }
    }

    class Ejercicio2()
    {
        /*Solicita al usuario dos números. Si el primero es mayor, devuelva
        su doble, de lo contrario devuelva el triple del segundo.  */
        public void run()
        {
            Console.WriteLine("Digita el primer numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digita el segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());
            if (num1 > num2) Console.WriteLine($"El doble del primer numero es: {num1 * 2}");
            else Console.WriteLine($"El triple del segundo numero es: {num2 * 3}");
        }
    }

    class Ejercicio3()
    {
        /*Pide al usuario un número. Si es positivo, devuelve su raíz
        cuadrada, de lo contrario, devuelve su cuadrado.   */
        public void run()
        {
            Console.WriteLine("Digita un numero: ");
            double num = double.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine($"La raiz cuadrada del numero es: {Math.Sqrt(num)}");
            else Console.WriteLine($"El cuadrado del numero es: {num * num}");
        }
    }

    class Ejercicio4()
    {
        /*Pide al usuario el radio de un círculo y calcula su perímetro. */
        public void run()
        {
            Console.WriteLine("Digita el radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine($"El perimetro del circulo es: {2 * Math.PI * radio}");
        }
    }

    class Ejercicio5()
    {
        /* Solicita al usuario un número entre 1 y 7 y muestra el día de la
        semana correspondiente, pero solo considerando los días laborables. */

        public void run()
        {
            Boolean validar = true;
            int num = 0;

            while (validar == true)
            {
                Console.WriteLine("Digita un numero entre 1 y 7: ");
                num = int.Parse(Console.ReadLine());
                if (num > 7 || num < 1)
                {
                    Console.WriteLine("El numero no esta dentro del rango solicitado");
                }
                else
                {
                    validar = false;
                }
            }

            string dia = num switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                _ => "Número inválido. Solo se consideran días laborables (1-5)."
            };
            Console.WriteLine(dia);
        }
    }

    class Ejercicio6()
    {

        /* Solicita al usuario su salario anual y, si este excede los 12000,
        muestra el impuesto a pagar que es el 15% del excedente.  */
        public void run()
        {
            Console.WriteLine("Digita tu salario anual");
            double salario = double.Parse(Console.ReadLine());
            const double tope = 12000;
            if (salario > 12000) Console.WriteLine($"El impuesto a pagar es: {(salario - tope) * 0.15}");
            else Console.WriteLine("No aplica para pagar impuestos");
        }
    }

    class Ejercicio7()
    {
        /* Solicita dos números y muestra el residuo de la división del
        primero entre el segundo.  */

        public void run()
        {
            Console.WriteLine("Digita el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita el segundo numero, debe ser diferente de cero: ");
            int num2 = int.Parse(Console.ReadLine());

            while (num2 == 0)
            {
                Console.WriteLine("El segundo numero no puede ser cero, digita otro nuevamente: ");
                num2 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El residuo entre el numero {num1} y el numero {num2} es: {num1 % num2}");
        }
    }

    class Ejercicio8()
    {
        /* Calcula y muestra la suma de los números pares entre 1 y 50  */

        public void run()
        {
            Console.WriteLine("Suma de los numeros del 1 al 50");
            int cuenta = 0;
            for (int i = 2; i <= 50; i += 2)
            {
                cuenta = cuenta + i;
            }
            Console.WriteLine($"La suma de los numeros del 1 al 50 es: {cuenta}");
        }
    }

    class Ejercicio9()
    {
        public void run()
        {
            Console.WriteLine("Ingrese la primera fracción (ejemplo: 1/2):");
            string input1 = Console.ReadLine();

            Console.WriteLine("Ingrese la segunda fracción (ejemplo: 1/3):");
            string input2 = Console.ReadLine();

           
            var frac1 = ParseFraction(input1);
            var frac2 = ParseFraction(input2);

            
            int numerador = frac1.numerador * frac2.denominador - frac2.numerador * frac1.denominador;
            int denominador = frac1.denominador * frac2.denominador;

           
            int mcd = MCD(Math.Abs(numerador), Math.Abs(denominador));
            numerador /= mcd;
            denominador /= mcd;

            
            if (numerador == 0)
                Console.WriteLine("Resultado: 0");
            else
                Console.WriteLine($"Resultado: {numerador}/{denominador}");
        }

       
        static (int numerador, int denominador) ParseFraction(string input)
        {
            var partes = input.Split('/');
            int num = int.Parse(partes[0]);
            int den = int.Parse(partes[1]);
            return (num, den);
        }

        
        static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    class Ejercicio10()
    {
        /*  Descripción: Pide una palabra al usuario y muestra la longitud de esa palabra.   */

        public void run()
        {
            Console.WriteLine("Digita una palabra: ");
            String palabra = Console.ReadLine();

            int cantidadLetras = 0;
            foreach (char p in palabra)
            {
                cantidadLetras++;
            }

            Console.WriteLine($"La cantidad de letras de la palabra {palabra} es: {cantidadLetras}");
        }
    }

    class Ejercicio11()
    {
        /*  Pide al usuario cuatro números y muestra el promedio.   */
        public void run()
        {
            Console.WriteLine("Digita el primer numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digita el primer numero: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digita el primer numero: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digita el primer numero: ");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"El promedio de los 4 numeros digitados es: {(num1 + num2 + num3 + num4) / 4}");
        }
    }

    class Ejercicio12()
    {
        /* Pide al usuario cinco números y muestra el más pequeño. */

        public void run()
        {
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
            if (num1 > num2)
            {
                menor = num2;
            }
            else if (num2 > num3)
            {
                menor = num3;
            }
            else if (num3 > num4)
            {
                menor = num4;
            }
            else if (num4 > num5)
            {
                menor = num5;
            }
            else
            {
                menor = num1;
            }

            Console.WriteLine($"El numero menor de los 5 digitados es: {menor}");
        }
    }

    class Ejercicio13()
    {
        /* Pide una palabra al usuario y devuelve el número de vocales en
        esa palabra. */

        public void run()
        {

            Console.WriteLine("Digita una palabra: ");
            String palabra = (Console.ReadLine());

            int contador = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
                {
                    contador++;
                }
            }

            Console.WriteLine($"La cantidad de vocales de la palabra {palabra} es: {contador}");
        }
    }

    class Ejercicio14()
    {
        /*  Pide un número al usuario y devuelve el factorial de ese número. 
        */
        public void run()
        {
            Console.WriteLine("Digita un numero entero: ");
            int numero = int.Parse(Console.ReadLine());
            int factorial = numero;
            for (int i = (numero - 1); i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"El factorial del numero {numero} es: {factorial}");
        }
    }

    class Ejercicio15()
    {
        /**Descripción: Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos).*/
        public void run ()
        { 
        Console.WriteLine("Digita un numero: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero< 20 && numero> 10)
        {
            Console.WriteLine($"Numero {numero} dentro del rango");
        }
        else
        {
            Console.WriteLine($"Numero {numero} fuera del rango");
        }
    }
}

