
namespace calculadora
{
    class Program
    {
        static void main(string[] aergs)
        {
            Soma();
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

}

        static void Subtracao(){
            Console.Clear();
            co
        }
    }
}