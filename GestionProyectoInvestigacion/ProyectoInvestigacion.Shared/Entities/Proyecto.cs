using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInvestigacion.Shared.Entities
{
    public class Proyecto
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null;

        [Display(Name = "Fecha de inicio")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo fecha de inicio es obligatorio")]
        public string FechaInicio { get; set; } = null;

        [Display(Name = "Fecha de finalización")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo fecha de finalización es obligatorio")]
        public string FechaFin { get; set; } = null;

        [Display(Name = "Líder de Proyecto")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo líder es obligatorio")]
        public string Lider { get; set; } = null;

        [Display(Name = "Descripción de Proyecto")]
        [MaxLength(200)]
        [Required(ErrorMessage = "El campo descripción es obligatorio")]
        public string Descripcion { get; set; } = null;

        [Display(Name = "Área de investigación")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo área es obligatorio")]
        public string AreaInvest { get; set; } = null;

    }
}