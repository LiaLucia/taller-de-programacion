using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;

        public Empleo(double Psueldo,DateTime pFechaIngreso)
        {
            this.iSueldo = Psueldo;
            this.iFechaIngreso = pFechaIngreso;
        }
        public double Sueldo
        {
            get { return this.iSueldo; }
        }
        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }
        }
    }
}
