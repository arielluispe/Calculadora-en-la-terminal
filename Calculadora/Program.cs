using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("1 = suma");
                Console.WriteLine("2 = resta");
                Console.WriteLine("3 = multiplicacion");
                Console.WriteLine("4 = divicion");
                Console.WriteLine("5 = salir");

                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Por favor ingrese una opcion valida (1-5)");
                }

                if (opcion == 5)
                {
                    break;
                }

                int num1, num2;
                Console.WriteLine("Ingrese primer numero:");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Por favor ingrese un numero valido");
                }
                Console.WriteLine("Ingrese segundo numero:");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Por favor ingrese un numero valido");
                }

                int resultado;
                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("No es posible dividir por cero");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("Resultado: " + resultado);
                        }
                        break;
                }
            }
        }
    }
}
