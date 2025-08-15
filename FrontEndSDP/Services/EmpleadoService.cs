using AppBlazorSDP.Entities;

namespace AppBlazorSDP.Services
{
    public class EmpleadoService
    {
        private List<RepresentanteListCLS> lista;
        public EmpleadoService()
        {
            lista = new List<RepresentanteListCLS>();
            lista.Add(new RepresentanteListCLS { Num_Empl = 1, Nombre = "Empleado 1" });
            lista.Add(new RepresentanteListCLS { Num_Empl = 2, Nombre = "Empleado 2" });
        }
        public List<RepresentanteListCLS> listarRepresentantes()
        {
            return lista;
        }
        public void eliminarEmpleado(int Num_Empl)
        {
            var listaQueda = lista.Where(p => p.Num_Empl != Num_Empl).ToList();
            lista = listaQueda;
        }


        public List<JefeCLS> ListarJefes()
        {
            return new List<JefeCLS>
            {
            new JefeCLS { IdJefe = 1, Nombre = "Bob Smith" },
            new JefeCLS { IdJefe = 2, Nombre = "Sue Anderson" }
            };
        }

    }
}
