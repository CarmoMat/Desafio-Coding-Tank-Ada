using System;
class questao1
{
    //Escreva um programa que faça a leitura de 5 valores Inteiros do usuário.
    //Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, 
    //quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim,
    //quantos são negativos.Cada uma das informações deve ser escrita em uma linha diferente.
    static void Main()
    {
        Console.WriteLine("Questão 1");
        Console.WriteLine("________________________");
        Console.WriteLine("Digite 5 valores:");

        int[] entrada = new int[5];
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        for (int i = 0; i < 5; i++)
        {
         
            Console.Write($"Digite o {i + 1}° Número: ");

            if (int.TryParse(Console.ReadLine(), out int numeroDigitado))
            {
                entrada[i] = numeroDigitado;

                if (entrada[i] != 0)
                {
                    if (entrada[i] % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                       impares++;
                    }
                }

                if (entrada[i] > 0)
                {
                   positivos++;
                }
               else if (entrada[i] < 0)
                {
                    negativos++;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida, Digite um número inteiro");
                i--;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Resultados:");
        Console.WriteLine("________________________");
        Console.WriteLine($"A Quantidade de números pares é igual a: {pares}");
        Console.WriteLine($"A Quantidade de números impares é igual a: {impares}");
        Console.WriteLine($"A Quantidade de números positivos é igual a: {positivos}");
        Console.WriteLine($"A Quantidade de números negativos é igual a: {negativos}");
    }
}
