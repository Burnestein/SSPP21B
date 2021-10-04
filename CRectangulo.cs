using System.Drawing;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase que representa un rectangulo.
    //NJSA. 04/10/2021.
    //---------------------------------------------------------------------
    public class CRectangulo : CFigura
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int Base;
        private int Altura;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CRectangulo(int X, int Y, int Base, int Altura, Color Color) : base(X, Y, Color) //: base() manda a llamar el constructor de la clase padre
        {
            this.Base = Base;
            this.Altura = Altura;
            Nombre = "rectangulo";
            Lapiz = new Pen(Color, 1);
        }

        //---------------------------------------------------------------------
        //Calcula el área del rectangulo.
        //---------------------------------------------------------------------
        public int CalculaArea()
        {
            return Base * Altura;
        }

        //---------------------------------------------------------------------
        //Dibuja el rectangulo.
        //---------------------------------------------------------------------
        public void Dibuja(Graphics AreaDibujo)
        {
            AreaDibujo.DrawRectangle(Lapiz, X, Y, Base, Altura);
        }
    }
}
