using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CastForCreationDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima es 50")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El personaje es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima es 50")]
        public string Character { get; set; }
    }
}