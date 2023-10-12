using System;

class questao4
{
    static void Main()
    {
        Int32 numero;
        numero = Convert.ToInt16(!(21 > 21));
        Console.WriteLine(numero);


        //A resposta é a alternativa (C)
        //Primeiro o código declara a variavel numero ao numero inteiro de 32bit com o valor inicial dela, sendo 0
        //em seguida tenta converter para um número inteiro de 16bit com os seguintes parametros dentro de colchetes
        //sendo 21>21 ele retorna falso, pois 21 não é maior que 21 e o simbolo ! que siginifica "Nao" diz não ser falso
        //então ele converte o número pra 16bit pois retorna true dos parametros e é convertido para número 1
    }
}