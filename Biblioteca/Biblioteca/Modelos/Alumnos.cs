using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Modelos
{
    public class Alumnos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El grado es obligatorio")]
        [StringLength(2, ErrorMessage = "Maximo 2 caracteres")]
        public string? Grado { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]
        public DateTime FechaN { get; set; }

        [Required(ErrorMessage = "El sexo es obligatorio")]
        [StringLength(9, ErrorMessage = "Haz alcanzado el maximo de caracteres")]
        public string? Sexo { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Correo { get; set; }

        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria")]
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")]
        public string? Direccion { get; set; }

        virtual public List<Prestamos>? Prestamos { get; set; }
    }
}
