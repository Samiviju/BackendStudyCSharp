using System;

namespace TestaPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto testando ponto flutuante!");

            double salario = 1250.70;
            Console.WriteLine(salario);

            Console.WriteLine("O meu salario é : " + salario);

            /* int valor = 12.5;
             // não compila.

             int valor2 = 0.0;
             //não compila.

             double valor2 = 125.50;
             //compila

             int valor3 = teste;
             //não compila.
            */

            int divisao = 5 / 2;
            Console.WriteLine(divisao);


            double divisao2 = 5.0 / 2;
            Console.WriteLine(divisao2);
             

            Console.WriteLine("Pressione a tecla 'enter' para fechar a janela...");




            Console.ReadLine();

           
        }
    }
}
