using System;

namespace _5_caracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura curso de tecnologia " + 2020;
            string cursosProgramação =
                @" - .NET
                - Java +
                - JavaScript";
                

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramação);



            
            





            Console.ReadLine();
        }
    }
}
