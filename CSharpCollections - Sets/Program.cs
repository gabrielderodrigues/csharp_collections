using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___Sets
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // SETS = CONJUNTOS

            // Duas propriedades do Set
            // 1. Não permite duplicidade
            // 2. Os elementos não são mantidos em ordem específica

            // Declarando Set de alunos
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            // Diferença entre Lista e Conjutos
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(", ", alunos));

            // Removendo Ana, adicionando Marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            // Verificando Duplicidade
            alunos.Add("Fabio Gushiken");

            // Vantagem sobre a Lista
            // 1. Conjunto é mais rapido pra buscar elementos
            // 2. Grande diferença entre performance
            // 3. Quanto mais elementos em uma lista, maior tempo de busca pra saber se o elemento existe
            // 4. Hashet não.
            // 5. Isso acontece pq o hashet quando você busca o elemento, ele utiliza a tabela de espalhamento
            // 6. ela direciona pra onde o elemento vai ocupar

            // Hashset X List : escalabilidade X memória

            // Ordenar: Sort

            //alunos.Sort();

            List<string> alunosEmLista = new List<string>(alunos);

            alunosEmLista.Sort();

            Console.WriteLine(string.Join(", ", alunosEmLista));


            Console.ReadLine();
        }
    }
}
