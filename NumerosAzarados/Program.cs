//Um número é azarado se contém um número 1 seguido por um 3 entre seus dígitos, ou seja, 
//sempre que houver o caracteres "13", ele será considerado um número azarado. Por exemplo, 
//o número 341329 é de má sorte, enquanto o número 12321 não é.
// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program
{
    public static void Main()
    {
        string numero = Console.ReadLine();

        // Verificar se o número contém a sequência "13"
        if (numero.Contains("13"))
        {
          //Obs: O teste esta pedindo a resposta em espanhol
            Console.WriteLine(numero + " es de Mala Suerte");
        }
        else
        {
            Console.WriteLine(numero + " NO es de Mala Suerte");
        }
    }
}