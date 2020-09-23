using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace UNIVERSIDADEPADAWAN.Controllers
{
    [ApiController]
    [Route("cadastro")]
    public class NotaController : ControllerBase
    {
        public static List<Models.Nota> listaNotas = new List<Models.Nota>();

        [HttpGet]
        [Route("mostraNotas")]
        public ActionResult GetNotas()
        {
            return Ok(listaNotas);
        }

        [HttpPost]
        [Route("adicionaNota")]
        public ActionResult Post(Models.Nota nota)
        {
            listaNotas.Add(nota);
            return Ok(listaNotas);

        }

        [HttpGet]
        [Route("buscaNotas")]
        public ActionResult Busca(int id)
        {
            var result = listaNotas.Where(x => x.Id == id).ToList();
            if (result.Count == 0)
                return BadRequest("não tem");
            else
                return Ok(result);

        }
        [HttpPut]
        [Route("atualizarNotas")]
        public ActionResult Atualizar(int id)
        {

            var resultado = listaNotas.Where(q => q.Id == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest("não encontrado");
            }
            resultado.Id = id;
            return Ok(listaNotas);

        }

        [HttpDelete]
        [Route("deletaNotas")]

        public ActionResult DeleteNotas(int id)
        {
            var result = listaNotas.Where(x => x.Id == id).FirstOrDefault(); ;
            if (result is null)
            {
                return BadRequest("não tem");
            }

            listaNotas.Remove(result);
            return Ok(result);
        }



    }
}
