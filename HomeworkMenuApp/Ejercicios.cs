using System;

class Ejercicios
{
    public void Ejercicio1()
    {
        /*Descripción: Solicita al usuario un número y eleva este número al cuadrado
        solo si es positivo. */
        Console.WriteLine("Digita un numero: ");
        double num = double.Parse(Console.ReadLine());
        if (num > 0) Console.WriteLine($"El cuadrado del numero es: {num * num}");
        else if (num < 0) Console.WriteLine("El numero es negativo");
        else Console.WriteLine("El numero es cero");
    }

    public void Ejercicio2()
    {
        /*Solicita al usuario dos números. Si el primero es mayor, devuelva
        su doble, de lo contrario devuelva el triple del segundo.  */

        Console.WriteLine("Digita el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digita el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());
        if (num1 > num2) Console.WriteLine($"El doble del primer numero es: {num1 * 2}");
        else Console.WriteLine($"El triple del segundo numero es: {num2*3}");
    }

    public void Ejercicio3()
    {
        /*Pide al usuario un número. Si es positivo, devuelve su raíz
        cuadrada, de lo contrario, devuelve su cuadrado.   */
        Console.WriteLine("Digita un numero: ");
        double num = double.Parse(Console.ReadLine());
        if (num > 0) Console.WriteLine($"La raiz cuadrada del numero es: {Math.Sqrt(num)}");
        else Console.WriteLine($"El cuadrado del numero es: {num*num}");
    }

    public void Ejercicio4()
    {
        /*Pide al usuario el radio de un círculo y calcula su perímetro. */
        Console.WriteLine("Digita el radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());
        Console.WriteLine($"El perimetro del circulo es: {2*Math.PI*radio}");
    }

    public void Ejercicio5()
    {
        /* Solicita al usuario un número entre 1 y 7 y muestra el día de la
        semana correspondiente, pero solo considerando los días laborables. */


        Boolean validar = true;
        int num = 0;

        while (validar == true){
        Console.WriteLine("Digita un numero entre 1 y 7: ");
        num = int.Parse(Console.ReadLine());
        if (num > 7 || num < 1) 
        {
            Console.WriteLine("El numero no esta dentro del rango solicitado");
        }
        else 
        {
            validar =false;
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

    public void Ejercicio6()
    {
        /* Solicita al usuario su salario anual y, si este excede los 12000,
        muestra el impuesto a pagar que es el 15% del excedente.  */
        Console.WriteLine("Digita tu salario anual");
        double salario = double.Parse(Console.ReadLine());
        const double tope = 12000;
        if (salario > 12000) Console.WriteLine($"El impuesto a pagar es: {(salario - tope)*0.15}");
        else Console.WriteLine("No aplica para pagar impuestos");
    }

    public void Ejercicio7()
    {
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
    }

    public void Ejercicio8()
    {
        /* Calcula y muestra la suma de los números pares entre 1 y 50  */
        Console.WriteLine("Suma de los numeros del 1 al 50");
        int cuenta = 0;
        for (int i = 2; i <= 50; i += 2)
        {
            cuenta = cuenta + i;
        }
        Console.WriteLine($"La suma de los numeros del 1 al 50 es: {cuenta}");
    }

    public void Ejercicio9()
    {
        
    }

    public void Ejercicio10()
    {
        /*  Descripción: Pide una palabra al usuario y muestra la longitud de esa palabra.   */

        Console.WriteLine("Digita una palabra: ");
        String palabra = Console.ReadLine();

        int cantidadLetras = 0;
        foreach (char p in palabra)
        {
        cantidadLetras ++;
        }

        Console.WriteLine($"La cantidad de letras de la palabra {palabra} es: {cantidadLetras}");
    }

    public void Ejercicio11()
    {
        /*  Pide al usuario cuatro números y muestra el promedio.   */

        Console.WriteLine("Digita el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digita el primer numero: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digita el primer numero: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digita el primer numero: ");
        double num4 = double.Parse(Console.ReadLine());
        Console.WriteLine($"El promedio de los 4 numeros digitados es: {(num1+num2+num3+num4)/4}");
    }

    public void Ejercicio12()
    {
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
            
    }

    public void Ejercicio13()
    {
        /* Pide una palabra al usuario y devuelve el número de vocales en
        esa palabra. */

        Console.WriteLine("Digita una palabra: ");
        String palabra = (Console.ReadLine());

        int contador=0;
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i]=='a' || palabra[i]=='e' || palabra[i]== 'i' || palabra[i]=='o' || palabra[i]=='u')
            {
                contador ++;
            }
        }

        Console.WriteLine($"La cantidad de vocales de la palabra {palabra} es: {contador}");
    }

    public void Ejercicio14()
    {
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
    }

    public void Ejercicio15()
    {
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
    }
}