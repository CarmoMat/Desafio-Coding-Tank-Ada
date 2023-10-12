using System;

class questao3
{
    //Escreva um programa que recebe como entrada uma frase do usuário.Como saída o programa deve exibir 
    //no console as seguintes informações: quantas palavras são maiúsculas, quantas palavras são minúsculas, 
    //quantas palavras iniciam com letra maiúscula, quantas palavras iniciam com letra minúscula e a quantidade
    //de palavras.
    
    static void Main()
    {
        Console.WriteLine("Questão 3");
        Console.WriteLine("___________________");
        Console.WriteLine("Escreva uma frase:");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(' ');

        int palavrasMaiusculas = 0;
        int palavrasMinusculas = 0;
        int inicialMaiusculas = 0;
        int inicialMinusculas = 0;

        int totalPalavras = palavras.Length;

        for (int i = 0; i < totalPalavras; i++)
        {
            string palavra = palavras[i].Trim(); 

            if (palavra.Length > 0) 
            {
                
                if (char.IsUpper(palavra[0]))
                {
                    inicialMaiusculas++;
                    if (palavra.Length == 1 || palavra.Substring(1).All(char.IsLower))
                        palavrasMaiusculas++;
                }
                else
                {
                    inicialMinusculas++;
                    if (palavra.All(char.IsLower))
                        palavrasMinusculas++;
                }

            } 
        }

        Console.WriteLine();
        Console.WriteLine("Resultados:");
        Console.WriteLine("_________________________________________________________________");
        Console.WriteLine($"O total de Palavras Maiusculas é igual a: {palavrasMaiusculas}");
        Console.WriteLine($"O total de Palavras Minusculas é igual a: {palavrasMinusculas}");
        Console.WriteLine($"O total de Palavras iniciando com Maiusculas é igual a: {inicialMaiusculas}");
        Console.WriteLine($"O total de Palavras iniciando com Minusculas é igual a: {inicialMinusculas}");

    }
}