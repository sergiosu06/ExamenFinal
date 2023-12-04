using Examen.Context;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotoController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public PilotoController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("Agregar")]
        public IActionResult AgregarPiloto([FromBody] Piloto piloto)
        {
            _aplicacionContext.Piloto.Add(piloto);
            _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "ok");
        }
        [HttpGet]
        [Route("Mostrar")]
        public IActionResult MostrarPiloto()    
        {
            List<Piloto> lista = _aplicacionContext.Piloto.OrderByDescending(piloto => piloto.idPiloto).ToList();
            return StatusCode(StatusCodes.Status200OK, lista);
        }
        [HttpPut]
        [Route("Editar/")]
        public IActionResult EditarPiloto([FromBody] Piloto piloto)
        {
            _aplicacionContext.Piloto.Update(piloto);
            _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado");
        }
        [HttpDelete]
        [Route("Eliminar/")]
        public IActionResult EliminarPiloto(int? id)
        {
            Piloto piloto = _aplicacionContext.Piloto.Find(id);
            _aplicacionContext.Piloto.Remove(piloto);
           _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado");
        }
    }
}
