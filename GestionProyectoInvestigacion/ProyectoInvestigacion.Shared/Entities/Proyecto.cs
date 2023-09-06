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

        [Display (Name = "Nombre")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null;



    }
}
