using System.Drawing;

namespace SSPP21B
{
    //---------------------------------------------------------------------
    //Clase que representa un color.
    //NJSA. 25/08/2021.
    //---------------------------------------------------------------------
    public class CColor
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int Red;
        private int Green;
        private int Blue;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CColor(int Red, int Green, int Blue)
        {

            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
        }

        //---------------------------------------------------------------------
        //Obtiene el nombre del color.
        //---------------------------------------------------------------------
        public string GetNombreColor()
        {
            Color ColorInterno;

            ColorInterno = Color.FromArgb(Red, Green, Blue);

            return ColorInterno.Name;
        }

        //---------------------------------------------------------------------
        //Obtiene el color primitivo.
        //---------------------------------------------------------------------
        public Color GetColorPrimitivo()
        {
            Color ColorInterno;

            ColorInterno = Color.FromArgb(Red, Green, Blue);

            return ColorInterno;
        }
    }
}
