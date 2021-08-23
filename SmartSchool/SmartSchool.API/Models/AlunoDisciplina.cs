using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class AlunoDisciplina
    {
        public int AlunoId { get; set; }
        public Aluno aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina disciplina { get; set; }

        public AlunoDisciplina() { }
        public AlunoDisciplina(int alunoId,int disciplinaId)
        {
            AlunoId = alunoId;          
            DisciplinaId = disciplinaId;
           
        }
    }
}
