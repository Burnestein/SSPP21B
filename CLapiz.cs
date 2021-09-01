using System.Drawing;

namespace SSPP21B
{
    //---------------------------------------------------------------------
    //Clase que representa un lápiz.
    //NJSA. 23/08/2021.
    //---------------------------------------------------------------------
    public class CLapiz
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private CColor Color;
        private string Material;
        private int Tipo;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CLapiz(string NombreColor, string Material, int Tipo)
            {
                Color = new CColor(NombreColor);
                this.Material = Material;
                this.Tipo = Tipo;
            }

        //---------------------------------------------------------------------
        //Traza una linea.
        //---------------------------------------------------------------------
        public string Trazar(int TipoTrazo)
        {
            string TipoCadena;

            Tipo = TipoTrazo;

            switch (Tipo)
            {
                case 1:
                    TipoCadena = "dibujo";
                    break;
                case 2:
                    TipoCadena = "profesional";
                    break;
                case 3:
                    TipoCadena = "escolar";
                    break;
                default:
                    TipoCadena = "desconocido";
                    break;
            }

            return "Estoy trazando, soy un lápiz de tipo " + TipoCadena + ".";
        }

        //---------------------------------------------------------------------
        //Identifica el color, material y tipo de lápiz.
        //---------------------------------------------------------------------
        public string Identificar()
        {
            return "Hola, soy un lápiz de " + Material + " de color " + Color.GetNombreColor() + ".";
        }

        //---------------------------------------------------------------------
        //Obtiene el color del lápiz.
        //---------------------------------------------------------------------
        public Color GetColor()
        {
            return Color.GetColorPrimitivo();
        }
    }
}
