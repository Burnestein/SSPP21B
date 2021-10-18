using System;
using System.IO;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase para generar archivos de texto.
    //NJSA. 18/10/2021.
    //---------------------------------------------------------------------
    class CGeneradorArchivo
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private string Ruta;
        private string Nombre;
        private string Contenido;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CGeneradorArchivo(string Ruta, string Nombre)
        {
            this.Ruta = Ruta;
            this.Nombre = Nombre;
        }

        //---------------------------------------------------------------------
        //Asigna el contenido del archivo.
        //---------------------------------------------------------------------
        public void SetContenido(string Contenido)
        {
            this.Contenido = Contenido;
        }

        //---------------------------------------------------------------------
        //Guarda el archivo en el disco.
        //---------------------------------------------------------------------
        public bool Guarda()
        {
            bool Exito;
            try
            {
                using (StreamWriter sw = File.CreateText(Ruta + Nombre))
                {
                    sw.WriteLine(Contenido);
                }
                Exito = true;
            }
            catch(Exception Error)
            {
                Exito = false;
            }

            return Exito;
        }
    }
}
