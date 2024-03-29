﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___Equals_e_HashCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //vamos declarar o curso
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
            //...e adicionar 3 aulas a esse curso
            //Trabalhando com Listas - 21 minutos;
            //Criando uma Aula - 20 minutos
            //Modelando com Coleções - 24 minutos
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));
            //um aluno também tem matrícula!
            //vamos criar a class Aluno com Nome e NumeroMatricula

            //Instanciando 3 alunos com suas matrícula:
            //Vanessa Tonini - 34672
            //Ana Losnak - 5617
            //Rafael Nercessian - 17645
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);
            //Precisamos Matricular os alunos no curso, criando um método
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            //Imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            //no formato "[Nome: , Matrícula: ]"

            //Imprimir: "O aluno a1 está matriculado?"
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            //Criar um método EstaMatriculado
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));
            //Vamos instanciar uma aluna (Vanessa Tonini)
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            //e verificar se Tonini está matriculada
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));
            //Mas a1 == a Tonini?
            Console.WriteLine("a1 == a Tonini?");
            Console.WriteLine(a1 == tonini);
            //O que ocorreu? a1 é equals a Tonini?
            Console.WriteLine("a1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));
            //São diferentes! Precisamos então implementar Equals()
        }
    }
}
