using System.IO;

namespace LibreriaClases
{
    class cArchivo
    {

    #region LeerArchivo

        public void LeerArchivo()
        {

            //Leer el archivo
            //Usar split para separar
            using (var Texto = new StreamReader("C:\\Users\\t213\\Documents\\estructuras l\\Laboratorio2\\Archivos\\Farmaco.txt"))
            {
                string DatosLeidos;
                string[] LineaLeida = new string[1];
                char[] delimitadores = { '"', ',' };

                try
                {

                }
                catch (System.Exception)
                {

                    throw;
                }



            }


        }
#endregion


    }
}
