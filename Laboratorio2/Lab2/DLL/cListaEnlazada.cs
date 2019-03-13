using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class cListaEnlazada<T> : IEstructurasLineales<T>, IEnumerable<T> where T: IComparable
    {
       static cNodo<T> Raiz { get; set; }
       static int Contador { get; set; }

        public void Agregar(T Tinformacion)
        {
            //Asignando el primer valor a la raiz
            if (Contador == 0)
            {
                Raiz = new cNodo<T>(Tinformacion);
                Contador++;
                return;
            }
            //Asignando los siguientes valores 
            var Actual = new cNodo<T>(Tinformacion);
            var Auxiliar = Raiz;
            
            while(Auxiliar.cNSiguiente != null)
            {
                Auxiliar = Auxiliar.cNSiguiente;
            }
            Auxiliar.cNSiguiente = Actual;
            Contador++;

        }

        public IEnumerator<T> GetEnumerator()
        {
            var cActual = Raiz;
            while(cActual!= null)
            {
                yield return cActual.TInformacion;
                cActual = cActual.cNSiguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
