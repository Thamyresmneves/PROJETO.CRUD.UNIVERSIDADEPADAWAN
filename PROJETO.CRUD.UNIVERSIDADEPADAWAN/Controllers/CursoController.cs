using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace UNIVERSIDADEPADAWAN.Controllers
{
    [ApiController]
    [Route("cadastro")]
    public class CursoController : ControllerBase
    {
        public static List<Models.Curso> listaCurso = new List<Models.Curso>();

        [HttpGet]
        [Route("mostraCurso")]
        public ActionResult GetCurso()
        {
            return Ok(listaCurso);
        }

        [HttpPost]
        [Route("adicionaCurso")]

        public ActionResult Get(Models.Curso Curso)
        {
            listaCurso.Add(Curso);
            return Ok(listaCurso);
        }

        [HttpPost]
        [Route("buscaCurso")]

        public ActionResult GetAluno(string Curso)
        {
            var result = listaCurso.Where(x => x.NomeCurso.Contains(Curso)).ToList();
            if (result is null)
                return BadRequest("não tem");
            else
                return Ok(result);

        }

        [HttpDelete]
        [Route("deletaCurso")]

        public ActionResult DeleteAluno(string Curso)
        {
            var result = listaCurso.Where(x => x.NomeCurso == Curso).FirstOrDefault(); 
            if (result is null)
            {
                return BadRequest("não tem");
            }

            listaCurso.Remove(result);
            return Ok(listaCurso);
        }



    }
}
