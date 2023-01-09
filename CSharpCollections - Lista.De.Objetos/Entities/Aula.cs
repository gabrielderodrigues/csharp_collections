using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___Lista.De.Objetos.Entities
{
    public class Aula : IComparable<Aula>
    {
        public string titulo;
        public int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public int CompareTo(Aula other)
        {
            return titulo.CompareTo(other.titulo);
        }

        public override string ToString()
        {
            return $"[Título: {titulo}, Tempo: {tempo} minutos]";
        }
    }
}
