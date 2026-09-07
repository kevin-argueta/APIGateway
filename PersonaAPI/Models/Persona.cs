using System.ComponentModel.DataAnnotations;

namespace PersonaAPI.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string PrimerNombre { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? SegundoNombre { get; set; }
        [Required]
        [MaxLength(100)]
        public string PrimerApellido { get; set; } = string.Empty;
        [MaxLength(100)]
        public string? SegundoApellido { get; set; }
        [Required]
        [MaxLength(10)]
        public string DUI { get; set; } = string.Empty;
        [Required]
        public DateTime FechaNacimiento { get; set; }
    }
}
