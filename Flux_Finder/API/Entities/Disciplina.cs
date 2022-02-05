using System.Collections.Generic;

namespace Entities
{
    public class Disciplina
    {

        public Disciplina(string nome, List<int> pendencias)
        {
            this.Id = Disciplina.ID++;
            this.Pendencias = pendencias;
            this.Nome = nome;
        }
        public int Id { get; private set;}
        public string Nome { get; private set; }
        public List<int> Pendencias { get; private set; }
        private static int ID = 1;
    }
}