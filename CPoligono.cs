using System.Drawing;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase que representa un poligono.
    //NJSA. 11/10/2021.
    //---------------------------------------------------------------------
    class CPoligono : CFigura
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private Point[] Puntos;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CPoligono(Point[] Puntos, Color Color) : base(0, 0, Color) //: base() manda a llamar el constructor de la clase padre
        {
            this.Puntos = Puntos;
            Nombre = "poligono";
            Lapiz = new Pen(Color, 1);
        }

        //---------------------------------------------------------------------
        //Calcula el área del poligono.
        //---------------------------------------------------------------------
        public int CalculaArea()
        {
            return 0;
        }

        //---------------------------------------------------------------------
        //Dibuja el poligono.
        //---------------------------------------------------------------------
        public void Dibuja(Graphics AreaDibujo)
        {
            AreaDibujo.DrawPolygon(Lapiz, Puntos);
        }
    }
}
