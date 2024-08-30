using System.ComponentModel.DataAnnotations;

namespace TestCrud.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Motor {  get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }

    }
}
