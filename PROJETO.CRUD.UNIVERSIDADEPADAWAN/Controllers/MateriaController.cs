using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace UNIVERSIDADEPADAWAN.Controllers
{
    [ApiController]
    [Route("cadastro")]
    public class MateriaController : ControllerBase
    {
        public static List<Models.Materia> listaMateria = new List<Models.Materia>();

        [HttpGet]
        [Route("mostraMateria")]
        public ActionResult GetMateria()
        {
            return Ok(listaMateria);
        }

        [HttpPost]
        [Route("adicionaMateria")]

        public ActionResult Post(Models.Materia materia)
        {
            listaMateria.Add(materia);
            return Ok(listaMateria);
        }

        [HttpGet]
        [Route("buscaMateria")]

        public ActionResult Busca(int id)
        {
            var result = listaMateria.Where(x => x.Id == id).ToList();
            if (result.Count == 0)
                return BadRequest("não tem");
            else
                return Ok(result);

        }
        [HttpPut]
        [Route("atualizarMateria")]
        public ActionResult Atualizar(int id)
        {

            var resultado = listaMateria.Where(q => q.Id == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest("não encontrado");
            }
            resultado.Id = id;
            return Ok(listaMateria);

        }

        [HttpDelete]
        [Route("deletaMateria")]

        public ActionResult DeleteMateria(int id)
        {
            var result = listaMateria.Where(x => x.Id == id).FirstOrDefault(); 
            if (result is null)
            {
                return BadRequest("não tem");
            }

            listaMateria.Remove(result);
            return Ok(listaMateria);
        }



    }

}
