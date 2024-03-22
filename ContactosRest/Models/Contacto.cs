using System.ComponentModel.DataAnnotations;

namespace ContactosRest.Models
{
    public class Contacto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Company { get; set; }

        public string Nota { get; set; }
    }
}
