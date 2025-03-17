using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Project.ModelLayer;
using View;
using System.Runtime.CompilerServices;
using System.Numerics;
using OfficeOpenXml.Drawing.Chart;


namespace Project.PresenterLayer
{
    class Presenter
    {
        private Model model;
        private readonly View1 view;

        public Presenter(View1 view)
        {
            this.view = view;
            model = new Model();
        }
        public void Show_Initial_Presenter()
        {
            view.Show_Initial_DataGrid_View(model.Show_Initial_DataGrid_Model());
        }

        public void Show_Animals_In_Finca_Order_Presenter(int id)
        {
            view.Show_Animals_In_Finca_Order_Receive(model.Show_Animals_In_Finca_Order_Model(id));
        }

        public DataTable button_vis_mov_chapeta_Click_Presenter(string text)
        {
            return model.button_vis_mov_chapeta_Click_Model(text);
        }

        public void ExportExcelPresenter()
        {
            model.ExportExcelModel();
        }

        public void Insert_Movimiento_Presenter(
            string chapeta,
            int concepto,
            DateTime fecha,
            int fincaOrigen,
            int fincaDestino,
            int pesoOrigen,
            int pesoDestino,
            int animalTipo
        )
        {
            if(fincaOrigen == fincaDestino)
            {
                view.ShowMessage("Las fincas no pueden coincidir.");
                return;
            }
            //si el animal no existe, entonces sí o sí 
            // - la finca de origen es nula
            // - el concepto es compra o nacimiento
            bool exists = model.AnimalExists(chapeta);
            if (!exists)
            {
                if((concepto == 5 || concepto == 3) && fincaOrigen == -1)
                {
                    model.InsertAnimal(chapeta, animalTipo);
                } 
                 else if(fincaOrigen != -1)
                {
                    view.ShowMessage("El animal no puede tener finca origen.");
                    return;
                } 
                else
                {
                    view.ShowMessage("El animal es nuevo, pero el concepto no es ni compra ni nacimiento.");
                    return;
                }
            }
            if(exists && (concepto == 5 || concepto == 2))
            {
                view.ShowMessage("El animal existe, por lo que el concepto no puede ser ni compra ni nacimiento.");
                return;
            }
            if(fincaDestino == -1 && !(concepto == 4 || concepto == 1))
            {
                view.ShowMessage("Debe colocar un destino valido.");
                return;
            }

            Movimiento movimiento = new Movimiento
            {
                Chapeta = chapeta,
                Concepto = concepto,
                Fecha = fecha,
                FincaOrigen = fincaOrigen,
                FincaDestino = fincaDestino,
                PesoOrigen = pesoOrigen,
                PesoDestino = pesoDestino
            };
            bool success = model.InsertMovimiento(movimiento);
        }
        public void Insert_Compra_Presenter(
            int finca,
            string idProveedor,
            DateTime fecha,
            int pesoDespacho,
            string factura
        )
        {
            Compra compra = new Compra
            {
                Finca = finca,
                IdProveedor = idProveedor,
                Fecha = fecha,
                PesoDespacho = pesoDespacho,
                Factura = factura
            };
            bool success = model.InsertCompra(compra);
        }
        public void Insert_Venta_Presenter(
            int finca,
            string idCliente,
            DateTime fecha,
            int pesoDespacho,
            string factura
        )
        {
            Venta venta = new Venta
            {
                Finca = finca,
                IdCliente = idCliente,
                Fecha = fecha,
                PesoDespacho = pesoDespacho,
                Factura = factura
            };
            bool success = model.InsertVenta(venta);
        }


    }
}
