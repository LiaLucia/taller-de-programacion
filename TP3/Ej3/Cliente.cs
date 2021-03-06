﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


//Hace que sea visible para el Testing  
[assembly: InternalsVisibleTo("PruebasEJ3")]

namespace Ej3
{
     class Cliente
    {
        private string iNombre;
        private string iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente;
        private Empleo iEmpleo;

        public Cliente(string pnombre,string pApellido, DateTime pFechaNacimiento, TipoCliente pTipoCliente,Empleo pEmpleo)
        {
            this.iTipoCliente = pTipoCliente;
            this.iNombre = pnombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;
        }

        public string Nombre
        {
            get{return this.iNombre; }
        }
        public string Apellido
        {
            get { return this.iApellido; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.iFechaNacimiento; }
        }
        public TipoCliente TipoCliente
        {
            set { this.iTipoCliente=value; }
            get { return this.iTipoCliente; }
        }

        public Empleo Empleo
        {
            get { return this.iEmpleo; }
        }
    }
}
