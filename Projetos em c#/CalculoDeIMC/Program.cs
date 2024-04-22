using System;

class Program
{
    static void Main(string[] args)
    {
        string nome; // variavel do tipo string pra nome
        int idade; // variavel do tipo int pra idade
        double altura, peso; //variavel do tipo double pra altura e peso

        do //laço de repetição pra repetir pelo menos 1x
        {
            Console.WriteLine("Digite o nome da pessoa:"); //pequeno texto para mostrar ao usuario qual dado ele deve colocar
            nome = Console.ReadLine(); //para armazenar a entrada do usuario

            Console.WriteLine("Digite a idade da pessoa:");
            idade = int.Parse(Console.ReadLine()); // utilizamos o int.parse para converter a entrada do usuario de string para um numero inteiro

            Console.WriteLine("Digite a altura da pessoa em metros:");
            altura = double.Parse(Console.ReadLine()); // utilizamos o double.parse para converter a entrada do usuario de string para um numero float

            Console.WriteLine("Digite o peso da pessoa em quilogramas:");
            peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            string categoriaIMC, faixaEtaria;

            // Determinar categoria de IMC
            if (imc < 18.5) //se o imc for menor que 18,5 então esta abaixo do peso
                categoriaIMC = "Abaixo do peso";
            else if (imc < 25)
                categoriaIMC = "Normal"; //se o imc for menor que 25 então esta com o peso normal
            else if (imc < 30)
                categoriaIMC = "Sobrepeso"; //se o imc for menor que 30 então esta acima do peso
            else
                categoriaIMC = "Obeso"; // se não estiver dentro de nenhuma categoria acima ele esta obeso

            // Determinar faixa etária
            if (idade <= 12)
                faixaEtaria = "Criança";
            else if (idade <= 19)
                faixaEtaria = "Adolescente";
            else if (idade <= 59)
                faixaEtaria = "Adulto";
            else
                faixaEtaria = "Idoso";

            // Exibir relatório com interpolação de strings
            Console.WriteLine($"Relatório para {nome}:");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} ({categoriaIMC})"); //
            Console.WriteLine($"Faixa etária: {faixaEtaria}");

            // Perguntar ao usuário se deseja gerar outro relatório
            Console.WriteLine("Deseja gerar um novo relatório? (s/n)");
        } while (Console.ReadLine().ToLower() == "s");
    }
}
