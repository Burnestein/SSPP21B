using System.Drawing;
using System;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase que representa un circulo.
    //NJSA. 27/09/2021.
    //---------------------------------------------------------------------
    class CCirculo
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private Pen Lapiz;
        private string Nombre;
        private int Radio;
        private Color Color;
        private int X;
        private int Y;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCirculo(int X, int Y, int Radio, Color Color)
        {
            this.X = X;
            this.Y = Y;
            this.Radio = Radio;
            this.Color = Color;
            Nombre = "circulo";
            Lapiz = new Pen(Color, 3);
        }

        //---------------------------------------------------------------------
        //Obtiene el nombre del círclo.
        //---------------------------------------------------------------------
        public string GetNombre()
        {
            return Nombre;
        }

        //---------------------------------------------------------------------
        //Obtiene el color del círculo.
        //---------------------------------------------------------------------
        public Color GetColor()
        {
            return Color;
        }

        //---------------------------------------------------------------------
        //Calcula el área del círculo.
        //---------------------------------------------------------------------
        public double CalculaArea()
        {
            return Math.PI * Radio * Radio;
        }

        //---------------------------------------------------------------------
        //Dibuja el círculo.
        //---------------------------------------------------------------------
        public void Dibuja(Graphics AreaDibujo)
        {
            AreaDibujo.DrawEllipse(Lapiz, X, Y, Radio*2, Radio*2);
        }
    }
}
