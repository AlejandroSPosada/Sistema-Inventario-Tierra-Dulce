using System;

namespace Project.ModelLayer.EntityModel
{
    public class Venta
    {
        public int Finca { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int PesoDespacho { get; set; }
        public string Factura { get; set; }


        public Venta()
        {
            Finca = 0;
            Fecha = DateTime.Now;
            IdCliente = "";
            PesoDespacho = 0;
            Factura = "";
        }

        public Venta(int finca, string idCliente, DateTime fecha, int pesoDespacho, string factura)
        {
            Finca = finca;
            Fecha = fecha;
            IdCliente = idCliente;
            PesoDespacho = pesoDespacho;
            Factura = factura;
        }
    }
}