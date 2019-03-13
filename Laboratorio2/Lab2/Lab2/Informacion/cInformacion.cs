using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2.Models;


namespace Lab2.Informacion
{
    public class cInformacion
    {
        private static cInformacion Almacenar = null;

        public static cInformacion _Almacenar
        {
            get
            {
                if (Almacenar == null) Almacenar = new cInformacion();
                return Almacenar;
            }
        }

        //public LibreriaClases.cListaEnlazada<cCargarArchivo> cargarArchivos
        

        
        
        
    }
}