using System.ComponentModel.DataAnnotations;

namespace Examen.Models
{
    public class Hangares
    {
        [Key]
        public int idHangares { get; set; }
        public int numero { get; set; }
        public int capacidad { get; set; }
        public string localizacion { get; set; }
        public int idAvion { get; set; }
    }
}
