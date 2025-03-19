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
using Project.ModelLayer.EntityModel;
using Project.MessageSystem;
using Project.ModelLayer.Helpers;
using Project.ModelLayer.Repository;

namespace Project.PresenterLayer
{
    class Presenter
    {
        private Model model;
        private readonly View1 view;
        private readonly RepositoryFactory _repository;

        public Presenter(View1 view, RepositoryFactory repository)
        {
            this.view = view;
            model = new Model();
            _repository = repository;
        }

        public void GetMovimientoById(string id)
        {
            Movimiento myMovimiento = _repository.MovimientoRepository.SearchByID(id);
            if (myMovimiento == null)
            {
                ShowMessages.ShowMessage("el ID no existe");
                return;
            }
            view.button_act_mov_id_movimiento_Response(myMovimiento);
        }

        public void GetCompraById(string id)
        {
            Compra myCompra = _repository.CompraRepository.SearchByID(id);
            if (myCompra == null)
            {
                ShowMessages.ShowMessage("el ID no existe");
                return;
            }
            view.button_act_com_id_compra_Response(myCompra);
        }

        public void GetVentaById(string id)
        {
            Venta myVenta = _repository.VentaRepository.SearchByID(id);
            if (myVenta == null)
            {
                ShowMessages.ShowMessage("el ID no existe");
                return;
            }
            view.button_act_com_id_venta_Response(myVenta);
        }

        public void InitializeInventoryPresenter()
        {
            List<DataTable> myList = model.InitializeInventoryModel();
            view.InitializeInventoryView(myList);
        }

        public void ShowAnimalesFincaPresenter(int input)
        {
            view.ShowAnimalPorFincaView(model.Show_Animals_In_Finca_Order_Model(input));
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
                ShowMessages.ShowMessage("Las fincas no pueden coincidir.");
                return;
            }
            //si el animal no existe, entonces sí o sí 
            // - la finca de origen es nula
            // - el concepto es compra o nacimiento
            bool exists = _repository.AnimalRepository.IdExists(chapeta);
            if (!exists)
            {
                if((concepto == 5 || concepto == 3) && fincaOrigen == -1)
                {
                    model.InsertAnimal(chapeta, animalTipo);
                } 
                 else if(fincaOrigen != -1)
                {
                    ShowMessages.ShowMessage("El animal no puede tener finca origen.");
                    return;
                } 
                else
                {
                    ShowMessages.ShowMessage("El animal es nuevo, pero el concepto no es ni compra ni nacimiento.");
                    return;
                }
            }
            if(exists && (concepto == 5 || concepto == 2))
            {
                ShowMessages.ShowMessage("El animal existe, por lo que el concepto no puede ser ni compra ni nacimiento.");
                return;
            }
            if(fincaDestino == -1 && !(concepto == 4 || concepto == 1))
            {
                ShowMessages.ShowMessage("Debe colocar un destino valido.");
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
