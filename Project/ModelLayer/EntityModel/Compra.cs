using System;

namespace Project.ModelLayer.EntityModel
{
    public class Compra
    {
        public int Finca { get; set; }
        public string IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int PesoDespacho { get; set; }
        public string Factura { get; set; }

        public Compra()
        {
            Finca = 0;
            Fecha = DateTime.Now;
            IdProveedor = "";
            PesoDespacho = 0;
            Factura = "";
        }

        public Compra(int finca, string idCliente, DateTime fecha, int pesoDespacho, string factura)
        {
            Finca = finca;
            Fecha = fecha;
            IdProveedor = idCliente;
            PesoDespacho = pesoDespacho;
            Factura = factura;
        }
    }
}