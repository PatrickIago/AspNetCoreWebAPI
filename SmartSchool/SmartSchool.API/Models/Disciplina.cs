using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina 
    {
        public Disciplina() { }
        public Disciplina(int id, string nome , int professorid, Professor professor)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorid;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor professor { get; set; }

        public IEnumerable<AlunoDisciplina> Alunosdisciplinas { get; set; }

    }
}
