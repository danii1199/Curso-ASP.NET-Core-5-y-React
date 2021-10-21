using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.ViewModel
{
    public class MovieViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(30, ErrorMessage = "Nombre demasiado largo")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El genero es requerido")]
        public string Gender { get; set; }
    }
}