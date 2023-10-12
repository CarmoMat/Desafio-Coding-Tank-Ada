using System;

class questao5
{
    static void Main()
    {
        for (int i = -5; i <= 7; i += 3)
        {
            Console.WriteLine(i);
        }

        // a resposta é a letra (E)
        //Pois o for é uma estrutura de repetição, sendo assim ele imprime primeiro o (-5)
        //porque é o valor inicial declarado na variavel i. Em seguida ele verifica se o -5 é menor ou igual a 7, 
        // caso seja ele faz -5 + 3 e retorna o (-2), ele verifica a condição novamente em loop tendo resultados (1),(4) e (7)
        //quando a condição que no caso é menor ou igual a 7 é atendida, ele imprime no console e sai do loop
    }
}