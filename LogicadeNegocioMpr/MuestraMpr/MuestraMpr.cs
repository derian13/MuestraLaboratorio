using LogicadeNegocio.Base;
using AccesoaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicadeNegocioMpr.MuestraMpr
{
    public class MuestraMapper
    {
        public static Muestra mapToMuestra(MuestraDeLaboratorio entity)
        {
            if (entity == null) return null;
            return new Muestra
            {
                Id = entity.Id,
                FechaDeToma = entity.FechaDeToma,
                NombrePersonaMuestreada = entity.NombrePersonaMuestreada,
                NombrePersonaTomaMuestra = entity.NombrePersonaTomaMuestra
            };
        }

        public static MuestraDeLaboratorio mapToEntity(Muestra dto)
        {
            if (dto == null) return null;
            return new MuestraDeLaboratorio
            {
                Id = dto.Id,
                FechaDeToma = dto.FechaDeToma,
                NombrePersonaMuestreada = dto.NombrePersonaMuestreada,
                NombrePersonaTomaMuestra = dto.NombrePersonaTomaMuestra
            };
        }
    }
}
