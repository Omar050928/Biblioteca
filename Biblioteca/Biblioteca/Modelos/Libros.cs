using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Modelos
{
    public class Libros
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "El editorial es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Editorial { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string? Categoria { get; set; }

        public DateTime FechaP { get; set; }

        [Required(ErrorMessage = "La descripción es obligatorio")]
        [StringLength(500, ErrorMessage = "Maximo 500 caracteres")]
        public string? Descripcion { get; set; }

        virtual public List<Prestamos>? Prestamos { get; set; }
    }
}
