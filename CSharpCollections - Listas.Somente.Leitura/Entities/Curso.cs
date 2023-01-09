using CSharpCollections___Lista.De.Objetos.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___Listas.Somente.Leitura.Entities
{
    public class Curso
    {
		private List<Aula> aulas;

		private string instrutor;

		private string nome;

		public Curso(string instrutor, string nome)
		{
			this.instrutor = instrutor;
			this.nome = nome;
			this.aulas = new List<Aula>();
		}

		public IList<Aula> Aulas
		{
			get { return new ReadOnlyCollection<Aula>(aulas); }
		}


		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}


		public string Instrutor
		{
			get { return instrutor; }
			set { instrutor = value; }
		}

		internal void AddClass(Aula aula)
		{
			this.aulas.Add(aula);
		}
	}
}
