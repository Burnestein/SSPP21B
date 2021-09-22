using System.Drawing;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase que representa un cuadrado.
    //NJSA. 22/09/2021.
    //---------------------------------------------------------------------
    public class CCuadrado
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private Pen Lapiz;
        private string Nombre;
        private int Lado;
        private Color Color;
        private int X;
        private int Y;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCuadrado(int X, int Y,int Lado, Color Color)
        {
            this.X = X;
            this.Y = Y;
            this.Lado = Lado;
            this.Color = Color;
            Nombre = "cuadrado";
            Lapiz = new Pen(Color);
        }

        //---------------------------------------------------------------------
        //Obtiene el nombre del cuadrado.
        //---------------------------------------------------------------------
        public string GetNombre()
        {
            return Nombre;
        }

        //---------------------------------------------------------------------
        //Obtiene el color del cuadrado.
        //---------------------------------------------------------------------
        public Color GetColor()
        {
            return Color;
        }

        //---------------------------------------------------------------------
        //Calcula el área del cuadrado.
        //---------------------------------------------------------------------
        public int CalculaArea()
        {
            return Lado * Lado;
        }

        //---------------------------------------------------------------------
        //Dibuja el cuadrado.
        //---------------------------------------------------------------------
        public void Dibuja(Graphics AreaDibujo)
        {
            AreaDibujo.DrawRectangle(Lapiz, X, Y, Lado, Lado);
        }
    }
}
