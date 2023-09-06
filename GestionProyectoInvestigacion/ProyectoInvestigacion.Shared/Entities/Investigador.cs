using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInvestigacion.Shared.Entities
{
    public class Investigador
    {

        public int Id { get; set; }

        [Display(Name="Nombre")]
        [MaxLength(50)]
        [Required (ErrorMessage ="El campo nombre es obligatorio")]
        public string Name { get; set; } =null;

        [Display(Name = "Afiliación institucional")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo afiliación es obligatorio")]
        public string Afiliacion { get; set; } = null;

        [Display(Name = "Especialización")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo especialización es obligatorio")]
        public string Especializacion { get; set; } = null;

        [Display(Name = "Rol")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El Rol es obligatorio")]
        public string Rol { get; set; } = null;


    }
}
