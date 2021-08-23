﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Aluno
    {

        public Aluno() { }
        public Aluno(int id, string nome, string sobrenome, int telefone)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Telefone { get; set; }

        public IEnumerable<AlunoDisciplina> Alunosdisciplinas { get; set; }



    }
}
