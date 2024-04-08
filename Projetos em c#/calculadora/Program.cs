using System;

namespace calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja calcular? ");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------");
            Console.WriteLine("selecione uma opção;");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine()); //utilizei float.parse para converter a string em numero
            Console.WriteLine("digite o segundo valor");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine(""); //Só para pular uma linha
            Console.WriteLine("o resultado da soma dos 2 numeros é " + resultado);
            Console.ReadKey();
            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"o resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"o resultado da divisão é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicao()
        {
            Console.Clear();
            Console.WriteLine("digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"o resultado da multiplicação é {resultado}");

            Console.ReadKey();
            Menu();
        }


    }
}