using CSharpCollections___Lista.De.Objetos.Entities;
using CSharpCollections___Listas.Somente.Leitura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___Listas.Somente.Leitura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Gabriel");
            csharpColecoes.AddClass(new Aula("Trabalhando com Listas", 21));

            Imprimir(csharpColecoes.Aulas);

            csharpColecoes.AddClass(new Aula("Criando uma Aula", 20));
            csharpColecoes.AddClass(new Aula("Modelando com Coleçõees", 19));

            Imprimir(csharpColecoes.Aulas);

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            Console.WriteLine("Tempo Total: " + csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);
            Console.ReadLine();
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
