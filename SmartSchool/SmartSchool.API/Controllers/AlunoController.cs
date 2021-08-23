using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> alunos = new List<Aluno>() {
            new Aluno()
            {
                Id = 1,
                Nome = "Patrick",
                Sobrenome = "Iago",
                Telefone = 123456
            },
             new Aluno()
            {
                Id = 2,
                Nome = "Marcos",
                Sobrenome = "Almeida",
                Telefone = 654321
            },
              new Aluno()
            {
                Id = 3,
                Nome = "Marta",
                Sobrenome = "Silva",
                Telefone = 987654
            }

        };
        public AlunoController() { }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(alunos);
        }

        
        [HttpGet("byId/{id}")]
        public IActionResult GetByid(int id)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null) return BadRequest("O aluno nao foi encontrado ");

            return Ok(aluno);
        }
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string Sobrenome)
        {
            var aluno = alunos.FirstOrDefault(a =>
            a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome));
       
            if (aluno == null) return BadRequest("O aluno nao foi encontrado ");

            return Ok(aluno);


        }
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {           
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id , Aluno aluno)
        {
            return Ok(aluno);
        }


        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}

