using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazorSDP.Entities
{
    public class JefeCLS
    {
        public int IdJefe { get; set; }

        [Required(ErrorMessage = "El nombre del Jefe es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

    }
}
