using System.Drawing;
using System;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase que representa un circulo.
    //NJSA. 27/09/2021.
    //---------------------------------------------------------------------
    public class CCirculo : CFigura
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int Radio;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCirculo(int X, int Y, int Radio, Color Color) : base(X, Y, Color)
        {
            this.Radio = Radio;
            Nombre = "circulo";
            Lapiz = new Pen(Color, 3);
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
