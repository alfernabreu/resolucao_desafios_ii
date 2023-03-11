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
        }

        public static void Main(string[] args)
        {
            string opcao;
            string escolha;
            Console.WriteLine("Bem-vindo(a)\nO propósito deste aplicativo é apresentar a versão invertida de uma palavra ou frase informada pelo usuário");
            do
            {
                Console.Write("Informe uma palavra ou frase para vê-la invertida: ");
                String palavra = Console.ReadLine();

                RetornaStringAoContrario(palavra);

                Console.Write("\nDeseja ver outra palavra ou frase invertida? Digite \"Sim\" ou \"Não\": ");
                opcao = Console.ReadLine();
                escolha = opcao.ToLower();

                while (escolha != "sim" & escolha != "não")
                {
                    Console.WriteLine("\nAtenção! Você digitou um valor inválido.");
                    Console.Write("Por favor, digite \"Sim\" ou \"Não\" caso deseja checar outro número: ");
                    opcao = Console.ReadLine();
                    escolha = opcao.ToLower();
                }

            } while (escolha == "sim");

            Console.WriteLine("\nObrigado pela escolha.\nPressione a tecla Enter para concluir.");

            Console.ReadLine();
        }
    }
}