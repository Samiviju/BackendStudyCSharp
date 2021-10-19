using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace ProjetoEstudando
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GerarPreco(20);
            GerarPreco(20);
            GerarPreco(89);
            GerarPreco(-68);
            GerarPreco(-84);

            Console.ReadLine();
            ;
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
        }
        static void GerarPreco(int preco )
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * preco);
            Console.WriteLine("Valor final: " + valorFinal);
           
        }
    }



    
}
