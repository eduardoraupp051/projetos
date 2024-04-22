using System;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        double altura, peso;

        do
        {
            Console.WriteLine("Digite o nome da pessoa:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da pessoa em metros:");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da pessoa em quilogramas:");
            peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            string categoriaIMC, faixaEtaria;

            // Determinar categoria de IMC
            if (imc < 18.5)
                categoriaIMC = "Abaixo do peso";
            else if (imc < 25)
                categoriaIMC = "Normal";
            else if (imc < 30)
                categoriaIMC = "Sobrepeso";
            else
                categoriaIMC = "Obeso";

            // Determinar faixa etária
            if (idade <= 12)
                faixaEtaria = "Criança";
            if (idade <= 19)
                faixaEtaria = "Adolescente";
            if (idade <= 59)
                faixaEtaria = "Adulto";
            else
                faixaEtaria = "Idoso";

            // Exibir relatório
            Console.WriteLine($"Relatório para {nome}:");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} ({categoriaIMC})");
            Console.WriteLine($"Faixa etária: {faixaEtaria}");

            // Perguntar ao usuário se deseja gerar outro relatório
            Console.WriteLine("Deseja gerar um novo relatório? (s/n)");
            while (Console.ReadLine().ToLower() == "s") ;
        }
}
