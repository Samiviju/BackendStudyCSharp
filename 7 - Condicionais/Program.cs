﻿using System;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - COndicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;




            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar!");
            }

            if (quantidadePessoas >= 2)
            {
                Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
            }
            else
            {
                Console.WriteLine("João não possui mas de 18 anos, não pode entrar");
            }



            Console.ReadLine();
        }
    }
}
