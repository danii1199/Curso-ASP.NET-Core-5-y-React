using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CastForupdateDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima es 50")]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "La longitud máxima es 50")]
        public string Character { get; set; }

    }
}