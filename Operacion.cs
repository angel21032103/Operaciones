﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    internal class Operacion
    {
        protected int valor1;
        public int Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        protected int valor2;   //atributo
        public int Valor2   //metodo
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        protected int resultado;
        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }        
    }
}
