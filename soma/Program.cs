/* Observe o trecho de código abaixo:
int INDICE = 13, SOMA = 0, K = 0;
enquanto K < INDICE faça
    {
    K = K + 1;
    SOMA = SOMA + K;
    }
imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA? */


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