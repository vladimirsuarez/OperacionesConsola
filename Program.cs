using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado, operacion = 0;
            char opcion;

            do
            {
                Console.WriteLine("+-       Menu de Opciones       -+");
                Console.WriteLine("+-    Calculo de Operaciones    -+");
                Console.WriteLine("+-1. Suma                       -+");
                Console.WriteLine("+-2. Resta                      -+");
                Console.WriteLine("+-3. Multiplicacion             -+");
                Console.WriteLine("+-4. Division                   -+");
                Console.WriteLine("\n +- Seleccione la operacion      -+");
                operacion = Convert.ToInt32(Console.ReadLine());

                switch (operacion)
                {
                    case 1:
                        Console.WriteLine("Digite el primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("\n El resultado de la suma es: " + resultado);
                        //Console.WriteLine("\n El resultado de la suma es: {1}",resultado);
                        break;

                    case 2:
                        Console.WriteLine("Digite el primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("\n El resultado de la resta es: " + resultado);
                        //Console.WriteLine("\n El resultado de la resta es: {1}",resultado);
                        break;

                    case 3:
                        Console.WriteLine("Digite el primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("\n El resultado de la multiplicacion es: " + resultado);
                        //Console.WriteLine("\n El resultado de la multiplicacion es: {1}",resultado);
                        break;

                    case 4:
                        Console.WriteLine("Digite el primer numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine("\n El resultado de la division es: " + resultado);
                        //Console.WriteLine("\n El resultado de la division es: {1}",resultado);
                        break;

                    case 5:
                        Console.WriteLine("¿Desea salir del programa (S/N)?");
                        opcion = char.ToUpper(char.Parse(Console.ReadLine()));

                        if (opcion == 'S')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                        }
                        break;

                    default:
                        Console.WriteLine("\n La opcion digitada no es valida.");
                        break;
                }

                Console.WriteLine("\n ¿Desea continuar con otra operacion (S/N)?");
                opcion = char.ToUpper(char.Parse(Console.ReadLine()));
                Console.Clear();
            }
            while (opcion == 'S');
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
