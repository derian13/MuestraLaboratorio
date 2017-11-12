using LogicadeNegocioApi.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicadeNegocio.Base;
using AccesoaDatos.Context;
using LogicadeNegocioMpr.MuestraMpr;
using AccesoaDatos.Modelo;
using System.Data.Entity;

namespace LogicadeNegocioMpr.NegocioMpr
{
    public class MuestraBusiness : IMuestraNegocio
    {
        public Muestra Create(Muestra muestra)
        {
            using (MyContext context = new MyContext())
            {
                MuestraDeLaboratorio retrievedEntity = context.MuestrasDeLaboratorio.Add(
                    MuestraMapper.mapToEntity(muestra)
                    );
                context.SaveChanges();
                return MuestraMapper.mapToMuestra(retrievedEntity);
            }
        }

        public List<Muestra> FindAll()
        {
            using (MyContext context = new MyContext())
            {
                return context.MuestrasDeLaboratorio.ToList()
                    .Select(MuestraMapper.mapToMuestra).ToList();
            }
        }

        public Muestra FindById(int id)
        {
            using (MyContext context = new MyContext())
            {
                return MuestraMapper.mapToMuestra(context.MuestrasDeLaboratorio.Find(id));
            }
        }

        public bool Remove(int Id)
        {
            using (MyContext context = new MyContext())
            {
                MuestraDeLaboratorio entity = new MuestraDeLaboratorio
                {
                    Id = Id
                };
                context.MuestrasDeLaboratorio.Attach(entity);
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
        }

        public Muestra Update(Muestra muestra)
        {
            using (MyContext context = new MyContext())
            {
                MuestraDeLaboratorio entity = context.MuestrasDeLaboratorio.Find(muestra.Id);
                entity.NombrePersonaMuestreada = muestra.NombrePersonaMuestreada;
                entity.NombrePersonaTomaMuestra = muestra.NombrePersonaTomaMuestra;
                entity.FechaDeToma = muestra.FechaDeToma;
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                return MuestraMapper.mapToMuestra(entity);
            }
        }
    }
}
