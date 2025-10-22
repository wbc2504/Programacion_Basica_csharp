using System;
namespace HomeworkMenuApp;
class Menu
{

    /*public Menu()
    {
        var ejercicios = new Ejercicios();
    }
    */
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
                    var Ejercicio1 = new Ejercicio1();
                    Ejercicio1.run();
                    break;
                case "2":
                    var Ejercicio2 = new Ejercicio2();
                    Ejercicio2.run();
                    break;
                case "3":
                    var Ejercicio3 = new Ejercicio3();
                    Ejercicio3.run();
                    break;
                case "4":
                    var Ejercicio4 = new Ejercicio4();
                    Ejercicio4.run();
                    break;
                case "5":
                    var Ejercicio5 = new Ejercicio5();
                    Ejercicio5.run();
                    break;
                case "6":
                    var Ejercicio6 = new Ejercicio6();
                    Ejercicio6.run();
                    break;
                case "7":
                    var Ejercicio7 = new Ejercicio7();
                    Ejercicio7.run();
                    break;
                case "8":
                    var Ejercicio8 = new Ejercicio8();
                    Ejercicio8.run();
                    break;
                case "9":
                    var Ejercicio9 = new Ejercicio9();
                    Ejercicio9.run();
                    break;
                case "10":
                    var Ejercicio10 = new Ejercicio10();
                    Ejercicio10.run();
                    break;
                case "11":
                    var Ejercicio11 = new Ejercicio11();
                    Ejercicio11.run();
                    break;
                case "12":
                    var Ejercicio12 = new Ejercicio12();
                    Ejercicio12.run();
                    break;
                case "13":
                    var Ejercicio13 = new Ejercicio13();
                    Ejercicio13.run();
                    break;
                case "14":
                    var Ejercicio14 = new Ejercicio14();
                    Ejercicio14.run();
                    break;
                case "15":
                    var Ejercicio15 = new Ejercicio15();
                    Ejercicio15.run();
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