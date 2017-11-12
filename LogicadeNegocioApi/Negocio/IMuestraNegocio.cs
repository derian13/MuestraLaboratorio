using LogicadeNegocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicadeNegocioApi.Negocio
{
    public interface IMuestraNegocio
    {
        Muestra Create(Muestra muestra);
        Muestra Update(Muestra muestra);
        bool Remove(int Id);
        List<Muestra> FindAll();

        Muestra FindById(int id);
    }
}
