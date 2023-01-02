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
