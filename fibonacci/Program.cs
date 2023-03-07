/* Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.


IMPORTANTE:

Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código; */


using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBem-vindo(a)!\nVamos checar se o número digitado pelo usuário pertence ao conjunto de valores que compõe a Sequência de Fibonacci.");

            bool valido = false;
            int numero;
            string opcao;
            string escolha = "sim";
            do 
            {
                Console.Write("Informe um número inteiro: ");
                numero = int.Parse(Console.ReadLine());

                int primeiro = 0;
                int segundo = 1;
                int terceiro = 1;

                List<int> sequenciaFibonacci = new List<int>();
                for (int i = 0; i < 50; i++)
                {
                    sequenciaFibonacci.Add(segundo);
                    terceiro = segundo;
                    segundo = primeiro + segundo;
                    primeiro = terceiro;
                }

                if(sequenciaFibonacci.Contains(numero))
                {
                    Console.WriteLine($"\nO número {numero} se encontra no conjunto de números que compõe a Sequência Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"\nO número {numero} não se encontra no conjunto de números que compõe a Sequência Fibonacci.");
                }

                Console.Write("\nVocê deseja checar outro número? Digite \"Sim\" ou \"Não\": ");
                opcao = Console.ReadLine();
                escolha = opcao.ToLower();

                while (escolha != "sim" & escolha != "não")
                {
                    Console.WriteLine("\nAtenção! Você digitou um valor inválido.");
                    Console.Write("Por favor, digite \"Sim\" ou \"Não\" caso deseje checar outro número: ");
                    opcao = Console.ReadLine();
                    escolha = opcao.ToLower();
                }

            } while (escolha == "sim");

            Console.WriteLine("\nObrigado pela escolha.");
        }
    }
}