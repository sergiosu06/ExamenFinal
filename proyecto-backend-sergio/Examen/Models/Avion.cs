using System.ComponentModel.DataAnnotations;

namespace Examen.Models
{
    public class Avion
    {
        [Key]
        public int idAvion{ get; set; }
        public int numero { get; set; }
        public string modelo { get; set; }
        public int peso { get; set; }
        public int capacidad { get; set; }
        public int idPiloto { get; set; }
    }
}
