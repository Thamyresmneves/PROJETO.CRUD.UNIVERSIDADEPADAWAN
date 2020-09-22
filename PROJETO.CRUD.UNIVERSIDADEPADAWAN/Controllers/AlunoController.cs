using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace UNIVERSIDADEPADAWAN.Controllers
{
    [ApiController]
    [Route("cadastro")]
    public class AlunoController : ControllerBase
    {
        public static List<Models.Aluno> listaAlunos = new List<Models.Aluno>();

        [HttpGet]
        [Route("mostraAluno")]
        public ActionResult GetAluno()
        {
            return Ok(listaAlunos);
        }

        [HttpPost]
        [Route("adicionaAluno")]

        public ActionResult Post(Models.Aluno Aluno)
        {
            listaAlunos.Add(Aluno);
            return Ok(listaAlunos);
        }

        [HttpGet]
        [Route("buscaAluno")]

        public ActionResult Busca(string nome)
        {
            var result = listaAlunos.Where(x => x.Nome.Contains(nome)).ToList();
            if (result.Count == 0)
                return BadRequest("não tem");
            else
                return Ok(result);

        }
        [HttpGet]
        [Route("mostraTodosAlunos")]

        public ActionResult Mostra(string nome)
        {
            var result = listaAlunos;
            if (result.Count == 0)
                return BadRequest("não tem");
            else
                return Ok (listaAlunos);

        }
        [HttpPut]
        [Route("atualizarAluno")]
        public ActionResult Atualizar(string nome)
        {

            var resultado = listaAlunos.Where(q => q.Nome == nome).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest("não encontrado");
            }
            resultado.Nome = nome;
            return Ok(listaAlunos);

        }

        [HttpDelete]
        [Route("deletaAluno")]

        public ActionResult DeleteAluno(string cpf)
        {
            var result = listaAlunos.Where(x => x.Cpf == cpf).FirstOrDefault();
            if (result is null)
            {
                return BadRequest("não tem");
            }

            listaAlunos.Remove(result);
            return Ok(listaAlunos);
        }



    }
}
