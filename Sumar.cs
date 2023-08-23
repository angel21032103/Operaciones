using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    internal class Sumar : Operacion    //herencia de la clase operacion
    {
        public int operar(int v1,int v2)
        {
            valor1 = v1;    //se puede acceder a los atributos directamente
            valor2 = v2;    //porla relacion de herencia
            return resultado = valor1 + valor2; 
        }
    }
}
