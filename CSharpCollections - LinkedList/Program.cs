using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "Abacate", "Banana", "Caqui", "Damasco", "Figo"
            };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // Adicionar um elemento ao final de uma lista é rápido.

            // Porém inserir no meio da lista exige mais esforço computacional

            // Porque os elementos têm que ser deslocados para darem
            // espaço ao novo elemento!
            // E se tivermos que remover esse elemento, os elementos
            // seguintes precisam ser deslocados de novo!

            // Quanto maior a lista, mais ineficiente é a inserção
            // e remoção de elemento no meio dela!

            // Apresentando LISTA LIGADA
            // - Elementos não precisam estar em sequência em memória
            // - Cada elemento sabe quem é o anterior e o próximo
            // - Cada elemento é um "nó" que contem um valor

            // Instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            // Adicionando dia qualquer: quarta
            var d4 = dias.AddFirst("quarta");

            Console.WriteLine($"d4.Value = {d4.Value}");

            // Vamos adicionar segunda, antes da quarta:
            var d2 = dias.AddBefore(d4, "segunda");

            var d3 = dias.AddAfter(d2, "terça");

            var d6 = dias.AddAfter(d4, "sexta");

            var d7 = dias.AddAfter(d6, "sábado");

            var d5 = dias.AddBefore(d6, "quinta");

            var d1 = dias.AddBefore(d2, "domingo");

            // Lista ligada NÃO DÁ suporte ao acesso de índice: dias[0]
            // por isso podemos fazer um laço foreach mas não um for!
            var quarta = dias.Find("quarta");

            // Para removermos um elemento, podemos tanto
            // remover pelo valor quanto pela
            // referência do LinkedListNode
            // dias.Remove("quarta") ou dias.Remove(d4)
            dias.Remove("quarta");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.ReadLine();
        }
    }
}
