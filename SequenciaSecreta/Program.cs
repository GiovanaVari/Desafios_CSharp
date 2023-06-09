﻿/*Na calçada em frente ao Palácio Imperial, não se sabe a razão, existe uma sequência de N números 
desenhados no chão. A sequência tem a seguinte forma: ela começa e termina com o número 1; apenas os 
números 1 e 2 aparecem nela; e o número 2 aparece pelo menos uma vez. Veja um exemplo na coluna (a) 
da figura ao lado. Ninguém sabe o significado da sequência e, justamente por isso, várias teorias 
malucas surgiram. Uma delas diz que a sequência representa, na verdade, apenas um valor que estaria 
relacionado a um segredo dos imperadores. Esse valor é a quantidade máxima de números da sequência 
que poderiam ser marcados com um círculo, de modo que a sequência de números marcados não contenha 
dois números iguais consecutivos. A coluna (b) da figura ao lado ilustra uma sequência de 4 números 
marcados que obedece a restrição acima. Só que é possível marcar 7 números, como mostra a coluna (c) 
da figura.

Neste problema, dada a sequência original de números desenhados no chão da calçada, seu programa deve 
computar e imprimir a quantidade máxima de números da sequência que poderiam ser marcados com um círculo 
sem que haja dois números iguais consecutivos na sequência marcada.
*/
// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

class Program
{
    public static void Main()
    {
        int tamanhoSequencia = Convert.ToInt32(Console.ReadLine());
        int quantidadeNumerosMarcados = 0;
        int ultimoNumeroLido = 0; // Inicializa em zero, porque "Vi é igual a 1 ou 2";

        for (int i = 0; i < tamanhoSequencia; i++)
        {
            int vi = Convert.ToInt32(Console.ReadLine());

            // Verificando se o número lido (Vi) é diferente do último número lido para marcá-lo
            if (vi != ultimoNumeroLido)
            {
                quantidadeNumerosMarcados++;
            }

            ultimoNumeroLido = vi;
        }

        Console.WriteLine(quantidadeNumerosMarcados);
    }
}