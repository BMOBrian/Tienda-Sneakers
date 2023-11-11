using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneakers.Modelos
{
    public class Tienda
    {
        [Key]
        public int IdTienda { get; set; }

        [Required(ErrorMessage ="El Nombre es requerido")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Descripción es requerida")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El dato es requerido")]
        public bool Activo { get; set; }
    }
}
