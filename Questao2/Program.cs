using System;

class questao2
{
    //Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números inteiros, 
    //N1 por N2, que devem ser lidos do teclado.É importante observar que a máquina que irá executar este programa 
    //é capaz de efetuar apenas duas operações matemáticas: adição e subtração.Ou seja,
    //você não poderá usar os operadores de multiplicação, divisão, módulo etc.bem como truncamentos.

    static void Main()
    {
        Console.WriteLine("Questão 2");
        Console.WriteLine("_____________________");
        Console.Write("Digite o primeiro número inteiro (N1): ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número inteiro (N2): ");
        int n2 = int.Parse(Console.ReadLine());

        int multiplicacao = 0;
        int divisao = 0;

        try
        {
            if (n2 < 0)
            {
                n1 = -n1;
                n2 = -n2;
            }

            for (int i = 0; i < n2; i++)
            {
                multiplicacao += n1;
            }

            int sinal = ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0)) ? -1 : 1;

            while (n1 >= 0)
            {
                n1 -= sinal * n2;
                if (n1 >= 0)
                    divisao++;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não é possivel dividir por 0");
        }

        Console.WriteLine();
        Console.WriteLine("Resultados:");
        Console.WriteLine("_________________________________________________________________");
        Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
        Console.WriteLine($"O resultado da divisão é: {divisao}");
    }
}



