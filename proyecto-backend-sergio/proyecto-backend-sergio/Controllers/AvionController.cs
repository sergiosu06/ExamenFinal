using Examen.Context;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public AvionController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("Agregar")]
        public IActionResult AgregarAvion([FromBody] Avion avion)
        {
            _aplicacionContext.Avion.Add(avion);
            _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "ok");
        }
        [HttpGet]
        [Route("Mostrar")]
        public IActionResult MostrarAvion()
        {
            List<Avion> lista = _aplicacionContext.Avion.OrderByDescending(avion => avion.idAvion).ToList();
            return StatusCode(StatusCodes.Status200OK, lista);
        }
        [HttpPut]
        [Route("Editar/")]
        public IActionResult EditarAvion([FromBody] Avion avion)
        {
            _aplicacionContext.Avion.Update(avion);
            _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado");
        }
        [HttpDelete]
        [Route("Eliminar/")]
        public IActionResult EliminarAvion(int? id)
        {
           Avion avion = _aplicacionContext.Avion.Find(id);
            _aplicacionContext.Avion.Remove(avion);
           _aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado");
        }
    }
}
