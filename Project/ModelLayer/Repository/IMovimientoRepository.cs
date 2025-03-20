using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ModelLayer.Helpers;

namespace Project.ModelLayer.Repository
{
    public interface IMovimientoRepository
    {
       public Movimiento SearchByID(string id);
       public void DeleteByID(string id);

       public void UpdateByID(Movimiento movimiento, string id);
    }
}
