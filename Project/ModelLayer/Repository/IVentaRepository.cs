using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelLayer.Repository
{
    public interface IVentaRepository
    {
        public Venta SearchByID(string id);
        public void DeleteByID(string id);
        public void UpdateByID(Venta venta, string id);
    }
}
