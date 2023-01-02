using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___Listas
{
    public class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro, 
            //    aulaModelando, 
            //    aulaSets
            //};

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            Console.WriteLine("");
            Console.WriteLine("Primeira Aula: " + aulas[0]);
            Console.WriteLine("Primeira Aula: " + aulas.First());
            Console.WriteLine("");
            Console.WriteLine("Ultima Aula: " + aulas[aulas.Count() - 1]);
            Console.WriteLine("Ultima Aula: " + aulas.Last());

            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            Console.WriteLine("A PRIMEIRA aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A ULTIMA aula 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A PRIMEIRA aula 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão"))); // vem null 

            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            aulas.Add("Conclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

            Console.ReadLine();
        }

        private static void Imprimir(List<string> aulas)
        {
            Console.WriteLine("");
            //for (int i = 0; i < aulas.Count(); i++)
            //{
            //    Console.WriteLine($"{i + 1}° aula: {aulas[i]}");
            //}

            aulas.ForEach(aula =>
            {
                Console.WriteLine($"Aula: {aula}");
            });
        }
    }
}
