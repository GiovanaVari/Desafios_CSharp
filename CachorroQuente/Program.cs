//Seu desafio é escrever um programa que calcule o número médio de cachorros-quentes 
//consumidos pelos participantes, dados o número total de cachorros-quentes consumidos 
//e o número total de participantes da competição.
// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split();
        int participantes = int.Parse(entrada[0]);
        int cachorrosQuentes = int.Parse(entrada[1]);

        // Calculando a média de cachorros-quentes consumidos
        double media = (double) participantes / cachorrosQuentes;

        // Imprimindo a média com duas casas decimais
        Console.WriteLine(media.ToString("F2"));
    }
}