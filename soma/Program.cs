using System;

namespace soma
{
    class Program
    {
        static void Main (string[] args)
        {
            int i = 13;
            int soma = 0;
            int k = 0;

            while (k < i)
            {
                k += 1;
                soma += k;
            }

            Console.WriteLine(soma);
        }
    }
}