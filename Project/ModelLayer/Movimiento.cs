using System;

namespace Project.ModelLayer
{
    public class Movimiento
    {
        public string Chapeta { get; set; }
        public int Concepto { get; set; }
        public DateTime Fecha { get; set; }
        public int FincaOrigen { get; set; }  
        public int FincaDestino { get; set; } 
        public int PesoOrigen { get; set; } 
        public int PesoDestino { get; set; } 

        
        public Movimiento()
        {
            Chapeta = "";
            Concepto = 0;
            Fecha = DateTime.Now;
            FincaOrigen = 0;
            FincaDestino = 0;
            PesoOrigen = 0;
            PesoDestino = 0;
        }

        public Movimiento(string chapeta, int concepto, DateTime fecha, int fincaOrigen, int fincaDestino, int pesoOrigen, int pesoDestino)
        {
            Chapeta = chapeta;
            Concepto = concepto;
            Fecha = fecha;
            FincaOrigen = fincaOrigen;
            FincaDestino = fincaDestino;
            PesoOrigen = pesoOrigen;
            PesoDestino = pesoDestino;
        }
    }
}

