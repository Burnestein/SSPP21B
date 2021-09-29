using System.Drawing;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase padre de todas las figuras geométricas.
    //NJSA. 29/09/2021.
    //---------------------------------------------------------------------
    public class CFigura
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        protected Pen Lapiz;
        protected string Nombre;
        protected Color Color;
        protected int X;
        protected int Y;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CFigura(int X, int Y, Color Color)
        {
            this.X = X;
            this.Y = Y;
            this.Color = Color;
        }
        //---------------------------------------------------------------------
        //Obtiene el nombre de la figura.
        //---------------------------------------------------------------------
        public string GetNombre()
        {
            return Nombre;
        }

        //---------------------------------------------------------------------
        //Obtiene el color de la figura.
        //---------------------------------------------------------------------
        public Color GetColor()
        {
            return Color;
        }
    }
}
