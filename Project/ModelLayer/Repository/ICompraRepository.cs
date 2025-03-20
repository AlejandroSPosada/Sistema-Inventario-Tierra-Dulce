using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelLayer.Repository
{
    public interface ICompraRepository
    {
        public Compra SearchByID(string id);
        public void DeleteByID(string id);
        public void UpdateByID(Compra compra, string id);
    }
}
