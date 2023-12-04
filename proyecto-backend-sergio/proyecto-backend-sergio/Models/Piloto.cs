using System.ComponentModel.DataAnnotations;
namespace Examen.Models
{
    public class Piloto
    {
        [Key]
        public int idPiloto { get; set; }
        public int numeroLicencia { get; set; }
        public string restricciones { get; set; }
        public double salario { get; set; }
        public string turno { get; set; }
    }
}
