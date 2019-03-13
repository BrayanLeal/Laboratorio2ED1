using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    class cNodo<T>
    {

        public T TInformacion { get; set; }
        public cNodo<T> cNSiguiente { get; set; }

        public cNodo(T Tinformacion)
        {
            TInformacion = Tinformacion;
            cNSiguiente = null;
        }

    }
}
