using Microsoft.AspNetCore.Mvc;
using ProjectSmartSchool2022.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectSmartSchool2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno()
        {
            Id = 1,
            Nome = "Marta",
            Sobrenome = "Almeida",
            Telefone = "6545456",
        },
            new Aluno()
        {
            Id = 2,
            Nome = "Marcos",
            Sobrenome = "Kent",
            Telefone = "4545645646",
        },
             new Aluno()
        {
            Id = 3,
            Nome = "Laura",
            Sobrenome = "Maria",
            Telefone = "5451958",
        }
        };


        // GET: api/<AlunoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        // GET api/aluno/byId
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrato");

            return Ok(aluno);
        }

        // GET api/aluno/nome
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a =>
            a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome));

            if (aluno == null) return BadRequest("O Aluno não foi encontrato");

            return Ok(aluno);
        }

        // POST api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        // PUT api/aluno
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // PATCH api/aluno
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // DELETE api/aluno
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}