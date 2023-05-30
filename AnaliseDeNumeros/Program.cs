// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de um array para armazenar os valores de entrada
            int[] valores = new int[5];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }

            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadePositivos = 0;
            int quantidadeNegativos = 0;

            foreach (int valor in valores)
            {
                if (valor % 2 == 0)
                {
                    quantidadePares++;
                }
                else
                {
                    quantidadeImpares++;
                }

                if (valor > 0)
                {
                    quantidadePositivos++;
                }
                else if (valor < 0)
                {
                    quantidadeNegativos++;
                }
            }

            Console.WriteLine("{0} par(es)", quantidadePares);
            Console.WriteLine("{0} impar(es)", quantidadeImpares);
            Console.WriteLine("{0} positivo(s)", quantidadePositivos);
            Console.WriteLine("{0} negativo(s)", quantidadeNegativos);
        }
    }
}