using System;

public class Autor
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }

    public Autor(string nome, string nacionalidade)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Autor: {Nome}, Nacionalidade: {Nacionalidade}");
    }
}
