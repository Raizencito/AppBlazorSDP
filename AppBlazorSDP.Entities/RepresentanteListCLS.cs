using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazorSDP.Entities
{
    public class RepresentanteListCLS
    {
        public int Num_Empl {  get; set; }
        public string Nombre { get; set; } = null!;
        public Departamento Sucursal { get; set; }
        public string NombreJefe { get; set; } = string.Empty;
    }
}
