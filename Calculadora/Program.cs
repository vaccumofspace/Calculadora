using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            

            while (!exit)
            {
                int[] nums;
                Console.Write("[1]Sumar\n[2]Restar\n[3]Multiplicar\n[4]Dividir\n[5]Salir\nOpcion: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        nums = Input();
                        Console.WriteLine($"\nEl resultado de la suma es {Calculadora.Sumar(nums[0], nums[1])}\n");
                        break;
                    case "2":
                        nums = Input();
                        Console.WriteLine($"\nEl resultado de la resta es {Calculadora.Restar(nums[0], nums[1])}\n");
                        break;
                    case "3":
                        nums = Input();
                        Console.WriteLine($"\nEl resultado de la multiplicacion es {Calculadora.Multiplicar(nums[0], nums[1])}\n");
                        break;
                    case "4":
                        nums = Input();
                        if(nums[1]==0){
                            Console.WriteLine("El resultado es indefinido");
                            break;
                        }
                        Console.WriteLine($"\nEl resultado de la division es {Calculadora.Dividir(nums[0], nums[1])}\n");
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nFavor inserte una de las opciones del 1 al 5");
                        break;

                }
            }
        }
        public static int[] Input()
        {
            Console.Write("Inserta el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Inserta el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int[] nums = { num1, num2 };

            return nums;
        }
    }
}
