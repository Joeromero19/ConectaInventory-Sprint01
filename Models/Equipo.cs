using System.ComponentModel.DataAnnotations;

namespace ConectaInventory.Models
{
    public class Equipo
    {
        [Key]
        [Display(Name = "Número de Serial")]
        public string NumSerial { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio.")]
        public string Modelo { get; set; }

        [Display(Name = "Estado Operativo")]
        public string EstadoOperativo { get; set; } = "Disponible";

        [Display(Name = "Ubicación ID")]
        public int IdUbicacion { get; set; }
    }
}