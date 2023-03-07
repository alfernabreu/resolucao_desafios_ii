using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo(a)!\nVamos checar se o número digitado pelo usuário pertence ao conjunto de valores que compõe a Sequência de Fibonacci.");

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

            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            if(sequenciaFibonacci.Contains(numero))
            {
                Console.WriteLine($"O número {numero} se encontra no conjunto de números que compõe a Sequência Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não se encontra no conjunto de números que compõe a Sequência Fibonacci.");
            }
        }
    }
}