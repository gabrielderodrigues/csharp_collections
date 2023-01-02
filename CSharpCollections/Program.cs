using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[]
            //{
            //    aulaIntro, 
            //    aulaModelando, 
            //    aulaSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);

            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulas[0] = "Trabalhando com Array";
            Imprimir(aulas);

            Console.WriteLine($"Aula modelando está no índice {Array.IndexOf(aulas, aulaModelando)}");
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando)); // pega a ultima ocorrencia do "aulaModelando" no array.

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            Array.Sort(aulas); // ordem alfabética
            Imprimir(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            string[] clone = (string[])aulas.Clone();
            Imprimir(clone);

            Array.Clear(clone, 1, 2);
            Imprimir(clone);

            Console.ReadLine();
        }

        private static void Imprimir(string[] aulas)
        {
            Console.WriteLine("");
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine($"{i+1}° aula: {aulas[i]}");
            }
        }
    }
}
