using Examen.Context;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangaresController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public HangaresController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("Agregar")]
        public IActionResult AgregarHangares([FromBody] Hangares hangares)
        {
            _aplicacionContext.Hangares.Add(hangares);
            _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "ok");
        }
        [HttpGet]
        [Route("Mostrar")]
        public IActionResult MostrarHangares()
        {
            List<Hangares> lista = _aplicacionContext.Hangares.OrderByDescending(hangares => hangares.idHangares).ToList();
            return StatusCode(StatusCodes.Status200OK, lista);
        }
        [HttpPut]
        [Route("Editar/")]
        public IActionResult EditarHangares([FromBody] Hangares hangares)
        {
            _aplicacionContext.Hangares.Update(hangares);
            _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado");
        }
        [HttpDelete]
        [Route("Eliminar/")]
        public IActionResult EliminarHangares(int? id)
        {
            Hangares hangares = _aplicacionContext.Hangares.Find(id);
            _aplicacionContext.Hangares.Remove(hangares);
           _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado");
        }
    }
}
