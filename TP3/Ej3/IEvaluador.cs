﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class  IEvaluador 
    {
        public virtual Boolean EsValida(SolicitudPrestamo pSolicitud)
        { return true;   }
    }
}
