﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class OpcionPedido
    {
        public int IdPedido { get; set; }
        public int IdOpcion { get; set; }
        public Opcion Opcion { get; set; }
        public Pedido Pedido { get; set; }
        
    }
}
