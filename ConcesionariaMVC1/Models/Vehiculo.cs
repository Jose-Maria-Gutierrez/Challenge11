using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConcesionariaMVC1.Models
{
    public class Vehiculo
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "marca obligatoria")]
        [StringLength(20,ErrorMessage = "exceso de caracteres")]
        public string marca { get; set; }
        [Required]
        [StringLength(20,ErrorMessage = "exceso de caracteres")]
        public string modelo { get; set; }
        [Display(Name = "año")]
        public int anio { get; set; }
        public int kilometros { get; set; }
        [Required(ErrorMessage = "precio obligatorio")]
        [Range(0,int.MaxValue,ErrorMessage = "numero invalido")]
        public double precio { get; set; }
    }
}
