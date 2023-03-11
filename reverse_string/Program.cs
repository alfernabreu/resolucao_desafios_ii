/* reverse_string.cs

Escreva um programa que inverta os caracteres de um string. */

using System;

namespace reverse_string
{
    class Program
    {
        private static void RetornaStringAoContrario(string palavra)
        {
            string palavraAoContrario = "";
            int extensaoDaPalavra;

            extensaoDaPalavra = palavra.Length - 1;

            while(extensaoDaPalavra >= 0)
            {
                palavraAoContrario += palavra[extensaoDaPalavra];
                extensaoDaPalavra --;
            }

            Console.WriteLine($"A expressão {palavra} em sua forma invertida é: {palavraAoContrario}");

            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            string novaPalavra;
            Console.WriteLine("Bem-vindo(a)\nO propósito deste aplicativo é apresentar a versão invertida de uma palavra ou frase informada pelo usuário");
            Console.Write("Informe uma palavra ou frase para vê-la invertida: ");
            String palavra = Console.ReadLine();

            RetornaStringAoContrario(palavra);
        }
    }
}


