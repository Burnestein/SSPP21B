using System.Drawing;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase que representa un cuadrado.
    //NJSA. 22/09/2021.
    //---------------------------------------------------------------------
    public class CCuadrado : CFigura
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int Lado;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCuadrado(int X, int Y,int Lado, Color Color) : base(X, Y, Color) //: base() manda a llamar el constructor de la clase padre
        {
            this.Lado = Lado;
            Nombre = "cuadrado";
            Lapiz = new Pen(Color, 1);
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
