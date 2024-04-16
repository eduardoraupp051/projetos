using System;
using System.IO;

namespace Texteditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("o que voce deseja fazer?");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo? ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair): ");
            Console.WriteLine("-----------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;

            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);
            {

                Salvar(text);
            }

        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("qual caminho para salvar arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"ARQUIVO {path} SALVO COM SUCESSO");
            Console.ReadLine();
            Menu();
        }
    }

}