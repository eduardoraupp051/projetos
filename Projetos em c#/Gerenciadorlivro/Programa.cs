using System;

public class Program
{
    public static void Main()
    {
        Autor autor = new Autor("Gabriel Garcia Marquez", "Colombiano");
        autor.MostrarInfo();

        
        Livro livro1 = new Livro("Cem Anos de Solidão", autor);
        livro1.MostrarInfo();

    
        livro1.AplicarDesconto(10.0);  // 10% de desconto
        livro1.MostrarInfo();


        Livro livro2 = new Livro("O Amor nos Tempos do Cólera", autor, 50.0);
        livro2.MostrarInfo();

       
        livro2.AplicarDesconto(5); 
        livro2.MostrarInfo();
    }
}
