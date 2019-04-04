using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        public AlunoController() { }

        // GET api/aluno
        [HttpGet]
        public ActionResult<IEnumerable<Aluno>> Gets()
        {
            Aluno aluno = new Aluno();
            return aluno.ListarAluno();
        }

        // GET api/aluno/5
        [HttpGet("{id}")]
        public ActionResult<Aluno> GetById(int id)
        {
            Aluno aluno = new Aluno();
            return aluno.ListarAluno().Where(x => x.id == id).FirstOrDefault();
        }

        // POST api/aluno
        [HttpPost("")]
        public List<Aluno> Post([FromBody] Aluno Aluno) 
        {
            Aluno _aluno = new Aluno();

            _aluno.Inserir(Aluno);

            return _aluno.ListarAluno();
        }

        // PUT api/aluno/5
        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] Aluno Aluno) 
        { 
            Aluno _aluno = new Aluno();

           return _aluno.Atualizar(id, Aluno);
        }

        // DELETE api/aluno/5
        [HttpDelete("{id}")]
        public void DeleteById(int id) 
        {
            Aluno _aluno = new Aluno();

            _aluno.Deletar(id);
        }
    }
}