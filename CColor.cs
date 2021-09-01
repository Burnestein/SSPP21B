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
        public CColor()
        {

            Red = -1;
            Green = -1;
            Blue = -1;
        }

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
        //Constructor.
        //---------------------------------------------------------------------
        public CColor(string NombreColor) //sobrecarga del objeto.
        {
            Color ColorInterno;

            ColorInterno = Color.FromName(NombreColor);

            Red = ColorInterno.R;
            Green = ColorInterno.G;
            Blue = ColorInterno.B;
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
