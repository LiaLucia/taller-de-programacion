﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Interfaz de evaluador
    /// </summary>
    interface  IEvaluador 
    {
        bool EsValida(SolicitudPrestamo pSolicitud);
        
    }
}
