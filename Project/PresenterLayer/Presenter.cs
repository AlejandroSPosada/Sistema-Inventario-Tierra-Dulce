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

        public void Insert_Movimiento_Presenter(
            string chapeta,
            int concepto,
            DateTime fecha,
            int fincaOrigen,
            int fincaDestino,
            int pesoOrigen,
            int pesoDestino
        )
        {
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

            // ✅ Notify the View
            //view.ShowMessage(success ? "Movimiento insertado con éxito" : "Error al insertar");
        }
    }
}
