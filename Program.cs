using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcore
{
    partial class Program
    {
        // Exercício 1:
        // - Fazer a média de notas dos dois alunos (Zuqui, Bronza) e imprimir no Console.WriteLine();
        // - Imprimir no console para cada aluno
        //      - Nome do aluno
        //      - Caso média maior ou igual 7:
        //          - Passou no ano letivo
        //          - Não passou no ano letivo
        // Requisítos:
        // - Criar um método "CalcularMedia", onde a entrada de parâmetros seja as notas e o retorno seja a média em float
        // - Utilizar For ou Foreach


        // Exercício 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maior idade
        // Requisítos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa
        static void Main(string[] args)
        {
            var xPessoas = new List<Pessoa>();
            xPessoas.Add(new Pessoa{ Idade= 18, Nome = "Zuqui"});
            xPessoas.Add(new Pessoa{ Idade= 27, Nome = "Bronza"});
            xPessoas.Add(new Pessoa{ Idade= 15, Nome = "Tomita"});
            xPessoas.Add(new Pessoa{ Idade= 35, Nome = "Joao"});

            var xMedia = xPessoas.Select(p => p.Idade).Average();
            Console.WriteLine("Media das idades: " + xMedia);
            var xMaisVelha = xPessoas.OrderByDescending(p => p.Idade).FirstOrDefault();
            Console.WriteLine("idade da pessoa mais velha: " + xMaisVelha.Idade + " Nome: " + xMaisVelha.Nome);
            var xMaisNova = xPessoas.OrderBy(p => p.Idade).FirstOrDefault();
            Console.WriteLine("idade da pessoa mais nova: " + xMaisNova.Idade + " Nome: " + xMaisNova.Nome);
            var xQuantidade = xPessoas.Where(p => p.Idade >= 18).Count();
            Console.WriteLine("Quantidade de pessoas com maior idade: " + xQuantidade);
            var xMenorIdade = xPessoas.Select(p => p.Idade).Min();
            Console.WriteLine("Menor idade: " + xMenorIdade);
            var xMaiorIdade = xPessoas.Select(p => p.Idade).Max();
            Console.WriteLine("Maior idade: " + xMaiorIdade);
        }
    }
}