using System.Collections.Generic;
using Entities;

namespace Data
{
    public class DataBase
    {
        public DataBase()
        {
            DisciplinasCadastradas = new List<Disciplina>();
            var APC = new Disciplina("ALGORITMOS E PROGRAMAÇÃO DE COMPUTADORES",new List<int> {});
            var EA= new Disciplina("ENGENHARIA E AMBIENTE",new List<int> {});
            var OO  = new Disciplina("ORIENTAÇÃO A OBJETOS",new List<int> {APC.Id});
            var MDS  = new Disciplina("MÉTODOS DE DESENVOLVIMENTO DE SOFTWARE ",new List<int> {OO.Id});

            DisciplinasCadastradas.Add(APC);
            DisciplinasCadastradas.Add(EA);
            DisciplinasCadastradas.Add(OO);
            DisciplinasCadastradas.Add(MDS);
        
        }    
        public List<Disciplina> DisciplinasCadastradas { get; private set; }
    }
}
