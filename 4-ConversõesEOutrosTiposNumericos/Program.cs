using System;

namespace _4_ConversõesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario; // O int é um tipo de variável que suporta até 32 bits na memória.

            Console.WriteLine(salarioEmInteiro);

            long idade_universo = 1300000000000000; //O long é uma variavel de 64 bits na memoria.
            Console.WriteLine("A idade do planeta é: " + idade_universo);


            short quantidadeProdutos;//O shor é um tipo de variável que suporta até 16 bits. 
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);



            float altura = 1.80f;
            Console.WriteLine(altura);

            




            Console.ReadLine();
        }
    }
}
