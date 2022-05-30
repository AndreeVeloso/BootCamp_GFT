﻿using System;

class Demos2
{
    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);
        System.Console.WriteLine($"O valor de a é {a}");
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }
    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }

    }
    static void Main()
    {
        var nomes = new string[] { "Jose", "Maria", "Andre", "Alice", "Pedro" };
        System.Console.WriteLine("Digite o nome que deseja ser substituido: ");
        var nome = System.Console.ReadLine();
        System.Console.WriteLine("Digite o novo nome que deseja substituir: ");
        var nomeNovo = System.Console.ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        System.Console.WriteLine($@"A lista de nomes Alterada é:
            {string.Join(", \n", nomes)}
        ");
    }
}
