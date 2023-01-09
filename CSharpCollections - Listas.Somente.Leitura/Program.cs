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
