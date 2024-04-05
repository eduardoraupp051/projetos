using System;

namespace calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subtracao();
        }
        static void Soma ()
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

}

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

        float resultado = v1 - v2;
            Console.WriteLine($"o resultado da subtração é {resultado}");

        Console.ReadKey();
        }
    }
}