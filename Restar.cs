using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    internal class Restar : Operacion
    {
        public int operar(int v1,int v2)
        {
            valor1 = v1;    //se pude acceder a los atributos directamente
            valor2 = v2;    //por la relacion de herencia
            return resultado = valor1 - valor2;
        }
    }
}
