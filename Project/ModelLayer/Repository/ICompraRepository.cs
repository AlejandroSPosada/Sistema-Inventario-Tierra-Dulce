﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelLayer.Repository
{
    public interface ICompraRepository
    {
        public Compra SearchByID(string id);
    }
}
