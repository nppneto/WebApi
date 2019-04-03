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
        [HttpGet("Todos")]
        public ActionResult<IEnumerable<Aluno>> Gets()
        {
            Aluno aluno = new Aluno();
            return aluno.listaAlunos();
        }

        // GET api/aluno/5
        [HttpGet("{id}")]
        public ActionResult<Aluno> GetById(int id)
        {
            Aluno aluno = new Aluno();
            return aluno.listaAlunos().Where(x => x.id == id).FirstOrDefault();
        }

        // POST api/aluno
        [HttpPost("")]
        public void Post([FromBody] string value) { }

        // PUT api/aluno/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/aluno/5
        [HttpDelete("{id}")]
        public void DeleteById(int id) { }
    }
}