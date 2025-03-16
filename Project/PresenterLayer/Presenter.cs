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
using Project.ModelLayer;
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
            model = new Model(this);
        }
        public void Show_Initial_Presenter()
        {
            view.Show_Initial_DataGrid_View(model.Show_Initial_DataGrid_Model());
            view.Show_Initial_ComboBox_View(model.Show_Initial_ComboBox_Model());
        }

        public void Show_Animals_In_Finca_Order_Presenter(int id)
        {
            view.Show_Animals_In_Finca_Order_Receive(model.Show_Animals_In_Finca_Order_Model(id));
        }
    }
}
