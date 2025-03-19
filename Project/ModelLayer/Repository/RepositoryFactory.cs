using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.ModelLayer.Repository
{
    public class RepositoryFactory
    {
        public ICompraRepository CompraRepository { get; }
        public IMovimientoRepository MovimientoRepository { get; }
        public IVentaRepository VentaRepository { get; }
        public IAnimalRepository AnimalRepository { get;  }

        public RepositoryFactory()
        {
            CompraRepository = new CompraRepository();
            MovimientoRepository = new MovimientoRepository();
            VentaRepository = new VentaRepository();
            AnimalRepository = new AnimalRepository();
        }
    }
}
