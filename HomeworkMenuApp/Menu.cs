using System;

class Menu
{
    private Ejercicios ejercicios;

    public Menu()
    {
        ejercicios = new Ejercicios();
    }

    public void MostrarMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menú de Ejercicios ===");
            Console.WriteLine("1. Elevar número al cuadrado (si es positivo)");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Ejercicio 5");
            Console.WriteLine("6. Ejercicio 6");
            Console.WriteLine("7. Ejercicio 7");
            Console.WriteLine("8. Ejercicio 8");
            Console.WriteLine("9. Ejercicio 9");
            Console.WriteLine("10. Ejercicio 10");
            Console.WriteLine("11. Ejercicio 11");
            Console.WriteLine("12. Ejercicio 12");
            Console.WriteLine("13. Ejercicio 13");
            Console.WriteLine("14. Ejercicio 14");
            Console.WriteLine("15. Ejercicio 15");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "0") break;

            Console.Clear();
            switch (opcion)
            {
                case "1":
                    ejercicios.Ejercicio1();
                    break;
                case "2":
                    ejercicios.Ejercicio2();
                    break;
                case "3":
                    ejercicios.Ejercicio3();
                    break;
                case "4":
                    ejercicios.Ejercicio4();
                    break;
                case "5":
                    ejercicios.Ejercicio5();
                    break;
                case "6":
                    ejercicios.Ejercicio6();
                    break;
                case "7":
                    ejercicios.Ejercicio7();
                    break;
                case "8":
                    ejercicios.Ejercicio8();
                    break;
                case "9":
                    ejercicios.Ejercicio9();
                    break;
                case "10":
                    ejercicios.Ejercicio10();
                    break;
                case "11":
                    ejercicios.Ejercicio11();
                    break;
                case "12":
                    ejercicios.Ejercicio12();
                    break;
                case "13":
                    ejercicios.Ejercicio13();
                    break;
                case "14":
                    ejercicios.Ejercicio14();
                    break;
                case "15":
                    ejercicios.Ejercicio15();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}