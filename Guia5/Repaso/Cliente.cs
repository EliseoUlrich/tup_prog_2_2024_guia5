﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Cliente
    {
        private string nombre;
        private string direccion;

        public Cliente(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public override string ToString()
        {
            return $"{nombre}  ( {direccion} )";
        }
    }
}
