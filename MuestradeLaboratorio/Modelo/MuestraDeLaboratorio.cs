using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoaDatos.Modelo
{
    public class MuestraDeLaboratorio
    {
        public int Id { get; set; }
        public string NombrePersonaMuestreada { get; set; }
        public DateTime FechaDeToma { get; set; }
        public string NombrePersonaTomaMuestra { get; set; }
    }
}
